package com.example.demo.domain.dto;


import com.example.demo.domain.entity.MusicEntity;
import lombok.AllArgsConstructor;
import lombok.Data;
import lombok.NoArgsConstructor;

@Data
@NoArgsConstructor
@AllArgsConstructor
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
