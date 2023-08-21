import 'package:flutter/material.dart';

class AppController extends ChangeNotifier{
  
  static AppController instance = AppController();
  
  bool isDartTheme = false;
  changeTheme() {
    isDartTheme = !isDartTheme;
    notifyListeners();
  }
}

class TecnobarFull extends ChangeNotifier {
  static TecnobarFull instance = TecnobarFull();
  
  String tecnobar = '';
  int contador = 0;

  void mudaTecnobar() {
    contador++;

    if (contador > 3) {
      contador = 1;
    }
    if (contador == 1) {
      tecnobar = 'TEC';
    } else if (contador == 2) {
      tecnobar = 'NO';
    } else if (contador == 3) {
      tecnobar = 'BAR';
    }
    
    notifyListeners();
  }

  Color getTextColor() {
    if (contador == 1) {
      return Colors.red;
    } else if (contador == 2) {
      return Colors.pink;
    } else if (contador == 3) {
      return Colors.blue;
    }
    return Colors.black;
  }
}