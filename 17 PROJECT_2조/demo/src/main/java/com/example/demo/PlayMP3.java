package com.example.demo;

import javazoom.jl.player.Player;
import org.jboss.jandex.Main;
import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.GetMapping;

import java.io.BufferedInputStream;
import java.io.File;
import java.io.FileInputStream;

@Controller
public class PlayMP3 extends Thread{


    private Player player;
    private boolean isLoop;
    private File file;
    private FileInputStream fis;
    private BufferedInputStream bis;


    public PlayMP3(String name, boolean isLoop){
        try{
            this.isLoop = isLoop;
            file = new File(Main.class.getResource("../music/"+name).toURI());
        }catch(Exception e){
            System.out.println(e.getMessage());
        }
    }

    public int getTime(){
        if(player == null)
            return 0;
        return player.getPosition();
    }
    public void close(){
        isLoop = false;
        player.close();
        this.interrupt();
    }

    @Override
    public void run(){
        try{
            do{
                player.play();
                fis = new FileInputStream(file);
                bis = new BufferedInputStream(fis);
                player = new Player(bis);
            }while(isLoop);
        }catch(Exception e){
            System.out.println(e.getMessage());
        }
    }

}