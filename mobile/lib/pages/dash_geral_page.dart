// ignore_for_file: prefer_const_constructors, prefer_const_literals_to_create_immutables

import 'package:flutter/material.dart';
import 'package:login/model/classe_dash.dart';
import 'package:syncfusion_flutter_charts/charts.dart';

class DashboardPage extends StatefulWidget {
  const DashboardPage({Key? key}) : super(key: key);

  @override
  State<DashboardPage> createState() => _DashboardPageState();
}

class _DashboardPageState extends State<DashboardPage> {
  String _filtro = '30dias';
  double _cardValue = 5000;
  Color _cor = Colors.blueGrey;
  late List<Produto> _chartData;
  late TooltipBehavior _tooltipBehavior;

  void initState() {
    _chartData = getChartData();
    _tooltipBehavior = TooltipBehavior(enable: true);
    super.initState();
  }

  List<Color> customColors = [
    Colors.red, Colors.green, Colors.blue
  ];
  List<Produto> getChartData() {
    final List<Produto> chartData = [
      Produto('Salgado', _cardValue),
      Produto('Refrigerante', _cardValue),
      Produto('Pastel', _cardValue),
    ];
    return chartData;
  }

  void _atualizaCards(String filter) {
    if (filter == '1dia') {
      _cardValue = 1000;
    } else if (filter == '7dias') {
      _cardValue = 7000;
    } else if (filter == '30dias') {
      _cardValue = 30000;
    } else if (filter == '3meses') {
      _cardValue = 90000;
    } else if (filter == '6meses') {
      _cardValue = 180000;
    } else if (filter == '1ano') {
      _cardValue = 360000;
    }
  }

  Widget _body() {
    return Padding(
      padding: EdgeInsets.all(8),
      child: ListView(
        children: [
          Container(
            alignment: Alignment.center,
            child: Text("Dados dos últimos:"),
          ),
          Container(
            alignment: Alignment.center,
            padding: EdgeInsets.all(8),
            child: DropdownButton<String>(
              value: _filtro,
              items: [
                DropdownMenuItem<String>(
                  value: '1dia',
                  child: Text('1 dia'),
                ),
                DropdownMenuItem<String>(
                  value: '7dias',
                  child: Text('7 dias'),
                ),
                DropdownMenuItem<String>(
                  value: '30dias',
                  child: Text('30 dias'),
                ),
                DropdownMenuItem<String>(
                  value: '3meses',
                  child: Text('3 meses'),
                ),
                DropdownMenuItem<String>(
                  value: '6meses',
                  child: Text('6 meses'),
                ),
                DropdownMenuItem<String>(
                  value: '1ano',
                  child: Text('1 ano'),
                ),
              ],
              onChanged: (String? newValue) {
                setState(() {
                  _filtro = newValue ?? '30dias';
                  _atualizaCards(_filtro);
                });
              },
            ),
          ),
          SizedBox(
            width: 150,
            height: 500,
            child: SfCircularChart(
              title: ChartTitle(text: 'Gráfico de Produtos'),
              legend: Legend(
                  isVisible: true, overflowMode: LegendItemOverflowMode.wrap),
              tooltipBehavior: _tooltipBehavior,
              series: <CircularSeries>[
                PieSeries<Produto, String>(
                  dataSource: _chartData,
                  xValueMapper: (Produto data, _) => data.nome,
                  yValueMapper: (Produto data, _) => data.preco,
                  dataLabelSettings: DataLabelSettings(isVisible: true),
                  enableTooltip: true,
                  strokeColor: Colors.black,
                  strokeWidth: 1,
                  pointColorMapper: (Produto data, _) => customColors[_chartData.indexOf(data)],
                ),
              ],
              // primaryXAxis: CategoryAxis(),
            ),
          ),
          SizedBox(
            height: 15,
          ),
          Container(
            alignment: Alignment.center,
            padding: EdgeInsets.all(8),
            child: Card(
              color: _cor,
              elevation: 5,
              shape: RoundedRectangleBorder(
                borderRadius: BorderRadius.circular(10),
              ),
              child: SizedBox(
                width: 500,
                height: 150,
                child: Column(
                  children: [
                    Container(
                      padding: EdgeInsets.all(10),
                      child: Text(
                        "Lucro",
                      ),
                    ),
                    Container(
                      padding: EdgeInsets.all(10),
                      child: Column(
                        crossAxisAlignment: CrossAxisAlignment.start,
                        children: [
                          SizedBox(height: 10),
                          Text(
                            "R\$ $_cardValue",
                          ),
                        ],
                      ),
                    ),
                  ],
                ),
              ),
            ),
          ),
          Container(
            alignment: Alignment.center,
            padding: EdgeInsets.all(8),
            child: Card(
              color: _cor,
              elevation: 5,
              shape: RoundedRectangleBorder(
                borderRadius: BorderRadius.circular(10),
              ),
              child: SizedBox(
                width: 500,
                height: 150,
                child: Column(
                  children: [
                    Container(
                      padding: EdgeInsets.all(10),
                      child: Text(
                        "Venda",
                      ),
                    ),
                    Container(
                      padding: EdgeInsets.all(10),
                      child: Column(
                        crossAxisAlignment: CrossAxisAlignment.start,
                        children: [
                          SizedBox(height: 10),
                          Text(
                            "R\$ $_cardValue",
                          ),
                        ],
                      ),
                    ),
                  ],
                ),
              ),
            ),
          ),
          Container(
            alignment: Alignment.center,
            padding: EdgeInsets.all(8),
            child: Card(
              color: _cor,
              elevation: 5,
              shape: RoundedRectangleBorder(
                borderRadius: BorderRadius.circular(10),
              ),
              child: SizedBox(
                width: 500,
                height: 150,
                child: Column(
                  children: [
                    Container(
                      padding: EdgeInsets.all(10),
                      child: Text(
                        "Faturamento",
                      ),
                    ),
                    Container(
                      padding: EdgeInsets.all(10),
                      child: Column(
                        crossAxisAlignment: CrossAxisAlignment.start,
                        children: [
                          SizedBox(height: 10),
                          Text(
                            "R\$ $_cardValue",
                          ),
                        ],
                      ),
                    ),
                  ],
                ),
              ),
            ),
          ),
        ],
      ),
    );
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      drawer: Drawer(
        child: Column(
          children: [
            UserAccountsDrawerHeader(
              currentAccountPicture:
                  ClipOval(child: Image.asset('assets/images/sonic.jpeg')),
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
          ],
        ),
      ),
      appBar: AppBar(
        title: Text('Home'),
        centerTitle: true,
      ),
      body: _body(),
    );
  }
}
