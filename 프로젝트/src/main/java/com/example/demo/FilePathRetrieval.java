package com.example.demo;

import org.springframework.context.annotation.Bean;
import org.springframework.context.annotation.Configuration;

import java.sql.*;


public class FilePathRetrieval {
    public static String connect() {
        String jdbcUrl = "jdbc:mysql://localhost:3306/musicdb";
        String username = "root";
        String password = "1234";

        String filePath = null;
        try (Connection connection = DriverManager.getConnection(jdbcUrl, username, password)) {
            String sql = "SELECT path FROM musicdb.music LIMIT 1"; // 첫 번째 행의 path 열만 가져오는 쿼리

            try (PreparedStatement preparedStatement = connection.prepareStatement(sql)) {
                ResultSet resultSet = preparedStatement.executeQuery();

                if (resultSet.next()) {
                    filePath = resultSet.getString("path");
                    System.out.println("File Path: " + filePath);
                } else {
                    System.out.println("파일을 찾을 수 없습니다.");
                }
            }
        } catch (SQLException e) {
            e.printStackTrace();
        }


        return filePath;
    }

}