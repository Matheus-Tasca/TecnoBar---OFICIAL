import 'package:flutter/material.dart';

class HomePage extends StatelessWidget {
  @override
  Widget build(BuildContext context) {
    return Scaffold(
      drawer: Drawer(
        child: Column(
          children: [
            UserAccountsDrawerHeader(
              currentAccountPicture: ClipOval(
                child: Image.asset('assets/images/sonic.jpeg')),
              accountName: Text("Tecnobar da silva"),
              accountEmail: Text("tecnobar@g.unicamp.br"),
            ),
            ListTile(
              leading: Icon(Icons.login),
              title: Text('Tela de Login'),
              subtitle: Text('Exercício 3'),
              onTap: () {
                Navigator.of(context).pushNamed('/login');
              },
            ),
            ListTile(
              leading: Icon(Icons.dashboard),
              title: Text('Dashboards Gerais'),
              subtitle: Text('Gere um dashboard'),
              onTap: () {
                Navigator.of(context).pushNamed('/dashGeral');
              },
            ),
          ],
        ),
      ),
      appBar: AppBar(
        title: Text('Salve Tânia'),
        centerTitle: true,
      ),
      body: Center(
          child: Text('Usuário para teste\n\nNome: Tecnobar\nSenha: 1234', style: TextStyle(fontSize: 30),),
        ),
    );
  }

}