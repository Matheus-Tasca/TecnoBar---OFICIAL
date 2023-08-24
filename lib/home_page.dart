import 'package:flutter/material.dart';
import 'package:tecnobar/app_controller.dart';
import 'datamodel_listview.dart';

class HomePage extends StatefulWidget {
  @override
  State<HomePage> createState() {
    return HomePageState();
  }
}

class HomePageState extends State<HomePage> {
  String tempo = '0', lucro = '0', venda = '0', faturamento = '0';

  final Map<String, Map<String, String>> valoresFicticios = {
    '1 Dia': {
      'lucro': '100,00 Reais',
      'venda': '50',
      'faturamento': '2.000,00 Reais',
    },
    '7 Dias': {
      'lucro': '500,00 Reais',
      'venda': '300',
      'faturamento': '6.000,00 Reais',
    },
    '30 Dias': {
      'lucro': '1.200 Reais',
      'venda': '800',
      'faturamento': '15.000,00 Reais',
    },
  };

  void updateTempo(String newTempo) {
    setState(() {
      tempo = newTempo;

      // Atualize as outras variáveis fictícias com base no novo tempo selecionado
      lucro = valoresFicticios[newTempo]!['lucro']!;
      venda = valoresFicticios[newTempo]!['venda']!;
      faturamento = valoresFicticios[newTempo]!['faturamento']!;
    });
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      drawer: Drawer(
        child: Column(
          children: [
            UserAccountsDrawerHeader(
              currentAccountPicture: ClipRRect(
                  borderRadius: BorderRadius.circular(40),
                  child: Image.asset('assets/images/logo.jpg')),
              accountName: Text('Tecnobar Oficial'),
              accountEmail: Text('Tecnobar@gmail.com'),
            ),
            ListTile(
              leading: Icon(Icons.home),
              title: Text('Home'),
              subtitle: Text('tela de inicio'),
              onTap: () {
                Navigator.of(context).pushReplacementNamed('/home');
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
            //SizedBox(height: 500,),
            Row(
              children: [
                Switch(
                  value: AppController.instance.isDartTheme,
                  onChanged: (value) {
                    AppController.instance.changeTheme();
                  },
                ),
                SizedBox(
                  width: 10,
                ),
                Text(
                  "Alterne o tema",
                  style: TextStyle(fontSize: 15, fontWeight: FontWeight.w500),
                ),
              ],
            ),
          ],
        ),
      ),
      appBar: AppBar(
        title: Text('Home Page'),
      ),
      body: Column(
        children: [
          Expanded(
            child: ListView(
              children: [
                Padding(
                  padding: const EdgeInsets.only(
                    top: 20,
                    right: 10,
                    left: 10,
                    bottom: 0,
                  ),
                  child: Column(
                    children: [
                      Card(
                        elevation: 20,
                        color: Colors.grey,
                        child: Padding(
                          padding: const EdgeInsets.only(
                            top: 20,
                            right: 10,
                            left: 25,
                            bottom: 30,
                          ),
                          child: Column(
                            mainAxisAlignment: MainAxisAlignment.center,
                            crossAxisAlignment: CrossAxisAlignment.stretch,
                            children: [
                              Text(
                                "Lucro",
                                style: TextStyle(fontSize: 20),
                              ),
                              SizedBox(
                                height: 10,
                              ),
                              Text(
                                "$tempo",
                                style: TextStyle(fontSize: 15),
                              ),
                              SizedBox(
                                height: 30,
                              ),
                              Row(
                                mainAxisAlignment: MainAxisAlignment.center,
                                children: [
                                  Text(
                                    "$lucro",
                                    style: TextStyle(fontSize: 30),
                                  ),
                                ],
                              ),
                            ],
                          ),
                        ),
                      ),
                      SizedBox(
                        height: 30,
                      ),
                      Card(
                        elevation: 20,
                        color: Colors.grey,
                        child: Padding(
                          padding: const EdgeInsets.only(
                            top: 20,
                            right: 10,
                            left: 25,
                            bottom: 30,
                          ),
                          child: Column(
                            mainAxisAlignment: MainAxisAlignment.center,
                            crossAxisAlignment: CrossAxisAlignment.stretch,
                            children: [
                              Text(
                                "Venda",
                                style: TextStyle(fontSize: 20),
                              ),
                              SizedBox(
                                height: 10,
                              ),
                              Text(
                                "$tempo",
                                style: TextStyle(fontSize: 15),
                              ),
                              SizedBox(
                                height: 30,
                              ),
                              Row(
                                mainAxisAlignment: MainAxisAlignment.center,
                                children: [
                                  Text(
                                    "$venda",
                                    style: TextStyle(fontSize: 30),
                                  ),
                                ],
                              ),
                            ],
                          ),
                        ),
                      ),
                      SizedBox(
                        height: 30,
                      ),
                      Card(
                        elevation: 20,
                        color: Colors.green,
                        child: Padding(
                          padding: const EdgeInsets.only(
                            top: 20,
                            right: 10,
                            left: 25,
                            bottom: 30,
                          ),
                          child: Column(
                            mainAxisAlignment: MainAxisAlignment.center,
                            crossAxisAlignment: CrossAxisAlignment.stretch,
                            children: [
                              Text(
                                "Faturamento",
                                style: TextStyle(fontSize: 20),
                              ),
                              SizedBox(
                                height: 10,
                              ),
                              Text(
                                "$tempo",
                                style: TextStyle(fontSize: 15),
                              ),
                              SizedBox(
                                height: 30,
                              ),
                              Row(
                                mainAxisAlignment: MainAxisAlignment.center,
                                children: [
                                  Text(
                                    "$faturamento",
                                    style: TextStyle(fontSize: 30),
                                  ),
                                ],
                              ),
                            ],
                          ),
                        ),
                      ),
                      Container(
                        child: Column(
                            mainAxisSize: MainAxisSize.min,
                            children: basicTiles.map((tile) {
                              return BasicTileWidget(
                                tile: tile,
                              );
                            }).toList()),
                      ),
                    ],
                  ),
                ),
              ],
            ),
          ),
        ],
      ),
    );
  }
}

class CustomSwitch extends StatelessWidget {
  const CustomSwitch({super.key});

  @override
  Widget build(BuildContext context) {
    return Row(
      children: [
        Icon(Icons.change_circle_outlined),
        //Text('troque o tema'),
        Switch(
          value: AppController.instance.isDartTheme,
          onChanged: (value) {
            AppController.instance.changeTheme();
          },
        ),
      ],
    );
  }
}

class BasicTileWidget extends StatelessWidget {
  final BasicTile tile;

  const BasicTileWidget({
    Key? key,
    required this.tile,
  }) : super(key: key);

  @override
  Widget build(BuildContext context) {
    final title = tile.title;
    final tiles = tile.tiles;

    if (tiles.isEmpty) {
      return ListTile(
        title: Text(title),
        onTap: () {
          HomePageState homePageState =
              context.findAncestorStateOfType<HomePageState>()!;
          homePageState.updateTempo(title);
          /*Utils.showSnackBar(
          context,
          text: 'Clicked on: $title',
          color: Colors.green,
        );*/
        },
      );
    } else {
      return Container(
        margin: EdgeInsets.all(16),
        decoration: BoxDecoration(
          color: Colors.white,
          borderRadius: BorderRadius.all(Radius.circular(8)),
          border: Border.all(color: Theme.of(context).primaryColor),
        ),
        child: ExpansionTile(
          key: PageStorageKey(title),
          title: Text(title),
          children: tiles.map((tile) => BasicTileWidget(tile: tile)).toList(),
        ),
      );
    }
  }
}
