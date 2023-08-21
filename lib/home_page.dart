import 'package:flutter/material.dart';
import 'package:tecnobar/app_controller.dart';

class HomePage extends StatefulWidget {
  @override
  State<HomePage> createState() {
    return HomePageState();
  }
}

class HomePageState extends State<HomePage> {
  int counter = 0;

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      drawer: Drawer(
        child: Column(
          children: [
            UserAccountsDrawerHeader(
              currentAccountPicture: ClipRRect(
                borderRadius: BorderRadius.circular(40),
                child: Image.asset('assets/images/logo.jpg')
              ),
              accountName: Text('Tecnobar Oficial'),
              accountEmail: Text('Tecnobar@gmail.com'),
            ),
            ListTile(
              leading: Icon(Icons.home),
              title: Text('Home'),
              subtitle: Text('tela de inicio'),
              onTap: () {
                print('home');
              },
            ),
            ListTile(
              leading: Icon(Icons.logout),
              title: Text('Logout'),
              subtitle: Text('Finalizar sessão'),
              onTap: () {
                Navigator.of(context).pushReplacementNamed('/');
              },
            ),
          ],
        ),
      ),
      appBar: AppBar(
        title: Text('Home Page'),
        actions: [CustomSwitch()],
      ),
      body: Container(
        width: double.infinity,
        height: double.infinity,
        //child: ListView(
        child: Column(
          mainAxisAlignment: MainAxisAlignment.center,
          //scrollDirection: Axis.vertical,
          children: [
            Text(
              TecnobarFull.instance.tecnobar,
              style: TextStyle(fontSize: 80, 
                fontWeight: FontWeight.bold,
                color: TecnobarFull.instance.getTextColor(),
              ),
            ),
            Text(
              'ALGUM CONTEUDO AQUI(clique no botão)', 
              style: TextStyle(fontSize: 40),
            ),
          ],
        ),
      ),
      floatingActionButton: FloatingActionButton(
        child: Icon(Icons.add),
        onPressed:() {
          setState(() {
              counter++;
            });
          TecnobarFull.instance.mudaTecnobar();
        },
        ),
    );
  }
}

class CustomSwitch extends StatelessWidget {
  const CustomSwitch({super.key});

  @override
  Widget build(BuildContext context) {
    return Switch(
      value: AppController.instance.isDartTheme,
      onChanged: (value) {
        AppController.instance.changeTheme();
      },
    );
  }
}