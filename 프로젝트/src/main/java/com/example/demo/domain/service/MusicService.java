package com.example.demo.domain.service;

import com.example.demo.domain.dto.MusicDto;
import com.example.demo.domain.entity.MusicEntity;
import org.springframework.stereotype.Component;
import org.springframework.stereotype.Service;
import org.springframework.transaction.annotation.Transactional;

import java.sql.*;

@Service
public class MusicService {



    @Transactional(rollbackFor = SQLException.class)
                public MusicDto connect(MusicDto dto) {
                    String jdbcUrl = "jdbc:mysql://localhost:3306/musicdb";
                    String username = "root";
                    String password = "1234";

                    String filePath = null;
                    String fileTitle = null;
                    MusicEntity Entity = new MusicEntity();
                    try (Connection connection = DriverManager.getConnection(jdbcUrl, username, password)) {
                        String sql = "SELECT * FROM music LIMIT 1 OFFSET 0";
                        System.out.println(sql);
                        try (PreparedStatement preparedStatement = connection.prepareStatement(sql)) {
                            ResultSet resultSet = preparedStatement.executeQuery();

                            Entity.setTitle(dto.getTitle());
                            Entity.setPath(dto.getPath());


                if (resultSet.next()) {
                    fileTitle = resultSet.getString("title");
                    filePath = resultSet.getString("path");

                    dto.setTitle(fileTitle);
                    dto.setPath(filePath);
                    System.out.println("File Title: " + fileTitle);
                    System.out.println("File Path: " + filePath);



                    return dto;

                } else {
                    System.out.println("파일을 찾을 수 없습니다.");
                }
            }
        } catch (SQLException e) {
            e.printStackTrace();
        }

        return null;
    }

}