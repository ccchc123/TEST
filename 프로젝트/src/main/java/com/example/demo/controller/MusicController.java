package com.example.demo.controller;


import com.example.demo.domain.dto.MusicDto;
import com.example.demo.domain.entity.MusicEntity;
import com.example.demo.domain.service.MusicService;
import javazoom.jl.player.Player;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.*;

import java.io.BufferedInputStream;
import java.io.File;
import java.io.FileInputStream;

@RestController
public class MusicController {
    private Player player;
    private boolean isLoop;
    private String currentMusicName;
    private FileInputStream finalFis;
    private BufferedInputStream finalBis;




//    private String filePath;

    @Autowired
    private MusicService musicService;



    @GetMapping("/play")
    public String playMusic(@RequestParam String isLoop, Model model,String title, String path, MusicDto dto){
        try {
            if (player != null) {
                player.close();
            }
            this.isLoop = Boolean.parseBoolean(isLoop);;


            MusicDto musicDto = musicService.connect(dto);
            String fileTitle = musicDto.getTitle();
            String filePath = musicDto.getPath();


            File file = new File(filePath);
            String absolutePath = file.getAbsolutePath();
            System.out.println("FILE : " +filePath);


            // 절대 경로 출력
            System.out.println("절대 경로: " + absolutePath);
            FileInputStream fis = new FileInputStream(absolutePath);
            BufferedInputStream bis = new BufferedInputStream(fis);
            player = new Player(bis);
            System.out.println("재생완료");

            model.addAttribute("MusicDto", musicDto);

            Thread playThread = new Thread(() -> {
                try {
                    do {
                        player.play();

                        FileInputStream fisloop = new FileInputStream(absolutePath);
                        BufferedInputStream bisloop = new BufferedInputStream(fisloop);
                        player = new Player(bisloop);
                    } while (Boolean.parseBoolean(isLoop));
                    System.out.println("반복중");
                } catch (Exception e) {
                    System.out.println(e.getMessage());
                }
            });
            playThread.start();
        } catch (Exception e) {
            System.out.println(e.getMessage());

        }
        return "play";
    }



    @GetMapping("/pause")
    public void pauseMusic() {
        if(player != null){
            player.close();
        }
    }

    @GetMapping("/stop")
    public int stopMusic() {
        if(player != null)
            player.close();
            System.out.println("멈춤");
            return 0;

    }

    @GetMapping("/time")
    public int getTime() {
        if (player == null)
            return 0;
        return player.getPosition();
    }
}