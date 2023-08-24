import 'package:flutter/material.dart';
import 'package:tecnobar/app_controller.dart';
import 'package:tecnobar/home_page.dart';
import 'package:tecnobar/login_page.dart';

class AppWidget extends StatelessWidget {

  @override
  Widget build(BuildContext context) {
    return AnimatedBuilder(
      animation: AppController.instance,
      builder: (context, child) {
      return MaterialApp(
        theme: ThemeData(
          primarySwatch: Colors.blueGrey,
          brightness: AppController.instance.isDartTheme 
          ? Brightness.dark 
          : Brightness.light,
          ),
          initialRoute: '/',
        routes: {
          '/': (context) => LoginPage(),
          '/home': (context) => HomePage(),
        },
      );
    });
  }
}