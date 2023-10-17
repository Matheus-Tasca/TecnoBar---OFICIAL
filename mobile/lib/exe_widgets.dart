import 'package:flutter/material.dart';
import 'package:login/pages/dash_geral_page.dart';
import 'pages/home_page.dart';
import 'pages/login_page.dart';

class ExeWidget extends StatelessWidget {
  @override
  Widget build(BuildContext context) {
    return MaterialApp(
      initialRoute: '/login',
      routes: {
        '/teste': (context) => HomePage(),
        '/login': (context) => LoginPage(),
        '/home': (context) => DashboardPage(),
      },
    );
  }
  
}