package com.example.demo.restcontroller;

import lombok.AllArgsConstructor;
import lombok.Builder;
import lombok.Data;
import lombok.NoArgsConstructor;

@Data
@AllArgsConstructor
@NoArgsConstructor
@Builder
public class MusicDto {

    private String title;
    private String path;


    public static MusicDto Of(MusicEntity musicEntity){
        MusicDto dto = new MusicDto();
        dto.title = musicEntity.getTitle();
        dto.path = musicEntity.getPath();
        return dto;
    }


}
