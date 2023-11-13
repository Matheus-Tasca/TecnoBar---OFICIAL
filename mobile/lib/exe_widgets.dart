import 'package:flutter/material.dart';
import 'package:login/pages/dashboard_page.dart';
import 'package:login/pages/home_page.dart';
import 'pages/history_page.dart';
import 'pages/login_page.dart';

class ExeWidget extends StatelessWidget {
  @override
  Widget build(BuildContext context) {
    return MaterialApp(
      initialRoute: '/login',
      routes: {
        '/login': (context) => LoginPage(),
        '/home': (context) => HomePage(),
        '/dash': (context) => DashboardPage(),
        '/history': (context) => HistoryPage(),
      },
      theme: ThemeData(
        primarySwatch: Colors.blueGrey,
        scaffoldBackgroundColor: Colors.white,
      ),
    );
  }
}