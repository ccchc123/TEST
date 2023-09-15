package com.example.demo;

import lombok.extern.slf4j.Slf4j;
import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.GetMapping;

@Controller
@Slf4j
public class controller {

    @GetMapping("/sing")
    public void sing(){

    }
    @GetMapping("/join")
    public void join(){

    }
}
