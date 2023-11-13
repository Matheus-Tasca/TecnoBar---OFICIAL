import 'package:flutter/material.dart';
import 'package:syncfusion_flutter_charts/charts.dart';
import '../model/classe_dash.dart';

class DashboardPage extends StatefulWidget {
  const DashboardPage({Key? key}) : super(key: key);

  @override
  State<DashboardPage> createState() => _DashboardPageState();
}

class _DashboardPageState extends State<DashboardPage> {
  String _selectedDate = '3 meses';
  String _selectedGraphType = '';
  String _selectedData = '';
  String _selectedCategory = '';
  bool _showChart = false;
  late List<Produto> _chartData;
  late TooltipBehavior _tooltipBehavior;

  void initState() {
    _chartData = getChartData();
    _tooltipBehavior = TooltipBehavior(enable: true);
    super.initState();
  }

  List<Produto> getChartDataByScale(String scale) {
    switch (scale) {
      case '1 mês':
        return _filterDataByScale(30);
      case '3 meses':
        return _filterDataByScale(90);
      case '6 meses':
        return _filterDataByScale(180);
      case '1 ano':
        return _filterDataByScale(365);
      default:
        return _chartData;
    }
  }

  List<Produto> _filterDataByScale(int days) {
    DateTime currentDate = DateTime.now();
    DateTime startDate = currentDate.subtract(Duration(days: days));

    return _chartData.where((produto) {
      DateTime dataProduto = _parseDate(produto.mes);
      return dataProduto.isAfter(startDate) &&
          dataProduto.isBefore(currentDate);
    }).toList();
  }

  DateTime _parseDate(String month) {
    List<String> monthNames = [
      'Janeiro',
      'Fevereiro',
      'Março',
      'Abril',
      'Maio',
      'Junho',
      'Julho',
      'Agosto',
      'Setembro',
      'Outubro',
      'Novembro',
      'Dezembro'
    ];

    int monthIndex = monthNames.indexOf(month) + 1;
    int currentYear = DateTime.now().year;

    return DateTime(currentYear, monthIndex);
  }

  List<Produto> getChartData() {
    final List<Produto> chartData = [
      Produto('Janeiro', 1000),
      Produto('Fevereiro', 1000),
      Produto('Março', 1000),
      Produto('Abril', 1000),
      Produto('Maio', 1000),
      Produto('Junho', 1000),
      Produto('Julho', 1000),
      Produto('Agosto', 1000),
      Produto('Setembro', 1000),
      Produto('Outubro', 1000),
      Produto('Novembro', 1000),
      Produto('Dezembro', 1000),
    ];
    return chartData;
  }

  Widget _body() {
    return ListView(
      padding: EdgeInsets.symmetric(vertical: 0, horizontal: 8),
      children: [
        buildForm('Tipo de gráfico', [
          buildSelectItem('Linha', 'Linha', () {
            setState(() {
              _selectedGraphType = 'Linha';
            });
          }),
          buildSelectItem('Barra', 'Barra', () {
            setState(() {
              _selectedGraphType = 'Barra';
            });
          }),
          buildSelectItem('Pizza', 'Pizza', () {
            setState(() {
              _selectedGraphType = 'Pizza';
            });
          }),
        ]),
        buildForm('Dado Desejado:', [
          buildSelectItem('Lucro', 'Lucro', () {
            setState(() {
              _selectedData = 'Lucro';
            });
          }),
          buildSelectItem('Vendas', 'Vendas', () {
            setState(() {
              _selectedData = 'Vendas';
            });
          }),
          buildSelectItem('Faturamento', 'Faturamento', () {
            setState(() {
              _selectedData = 'Faturamento';
            });
          }),
        ]),
        buildForm('Categoria', [
          buildSelectItem('Bebidas', 'Bebidas', () {
            setState(() {
              _selectedCategory = 'Bebidas';
            });
          }),
          buildSelectItem('Alimentos', 'Alimentos', () {
            setState(() {
              _selectedCategory = 'Alimentos';
            });
          }),
        ]),
        buildForm('Data', [
          DropdownButtonFormField<String>(
            value: _selectedDate,
            items: [
              '1 mês',
              '3 meses',
              '6 meses',
              '1 ano',
            ].map((String value) {
              return DropdownMenuItem<String>(
                value: value,
                child: Center(child: Text(value)),
              );
            }).toList(),
            onChanged: (String? newValue) {
              if (newValue != null) {
                setState(() {
                  _selectedDate = newValue;
                });
              }
            },
          ),
        ]),
        Container(
          margin: EdgeInsets.all(16),
          child: ElevatedButton(
            onPressed: () {
            if (_selectedGraphType.isNotEmpty &&
                _selectedData.isNotEmpty &&
                _selectedCategory.isNotEmpty &&
                _selectedDate.isNotEmpty) {
              setState(() {
                _showChart = true;
              });
            } else {
              _showMyDialog();
            }
          },
            child: Text('Gerar Dashboard'),
          ),
        ),
        if (_showChart) buildChart(),
      ],
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
                  ClipOval(child: Image.asset('assets/images/tecnobar.jpg')),
              accountName: Text("Tecnobar"),
              accountEmail: Text("tecnobar@g.unicamp.br"),
            ),
            ListTile(
              leading: Icon(Icons.home),
              title: Text('Home'),
              onTap: () {
                Navigator.of(context).pushNamed('/home');
              },
            ),
            ListTile(
              leading: Icon(Icons.dashboard),
              title: Text('Dashboard'),
              onTap: () {
                Navigator.of(context).pushNamed('/dash');
              },
            ),
            ListTile(
              leading: Icon(Icons.history_sharp),
              title: Text('Historico'),
              onTap: () {
                Navigator.of(context).pushNamed('/history');
              },
            ),
            ListTile(
              leading: Icon(Icons.login),
              title: Text('Sair'),
              onTap: () {
                Navigator.of(context).pushNamedAndRemoveUntil('/login', (route) => false);
              },
            ),
          ],
        ),
      ),
      appBar: AppBar(
        title: Text('Dashboard'),
        centerTitle: true,
      ),
      body: _body(),
    );
  }

  Widget buildForm(String title, List<Widget> items) {
    return Container(
      margin: EdgeInsets.all(16),
      child: Column(
        crossAxisAlignment: CrossAxisAlignment.start,
        children: [
          Text(
            title,
            style: TextStyle(fontSize: 18),
          ),
          SizedBox(height: 8),
          Row(
            children: items.map((item) => Expanded(child: item)).toList(),
          ),
        ],
      ),
    );
  }

  Widget buildSelectItem(
      String buttonText, String dataValue, VoidCallback onPressed) {
    bool isHighlighted = buttonText == _selectedGraphType ||
        buttonText == _selectedData ||
        buttonText == _selectedCategory;

    return Container(
      margin: EdgeInsets.all(8),
      child: ElevatedButton(
        onPressed: () {
          onPressed();
        },
        child: Text(
          buttonText,
          style: TextStyle(
            color: isHighlighted ? Colors.white : Colors.black,
          ),
        ),
        style: ElevatedButton.styleFrom(
          primary: isHighlighted ? Colors.blueGrey : Colors.white,
        ),
      ),
    );
  }

  Widget buildChart() {
    List<Produto> filteredData = getChartDataByScale(_selectedDate);
    if (_showChart) {
      if (_selectedGraphType == 'Pizza') {
        return SizedBox(
          width: 150,
          height: 400,
          child: SfCircularChart(
            title: ChartTitle(text: '$_selectedData de $_selectedCategory'),
            legend: Legend(
                isVisible: true, overflowMode: LegendItemOverflowMode.wrap),
            tooltipBehavior:
                TooltipBehavior(enable: true, format: 'point.x : point.y'),
            series: <CircularSeries>[
              PieSeries<Produto, String>(
                dataSource: filteredData,
                xValueMapper: (Produto data, _) => data.mes,
                yValueMapper: (Produto data, _) => data.valor,
                dataLabelSettings: DataLabelSettings(isVisible: true),
                enableTooltip: true,
                strokeColor: Colors.black,
                strokeWidth: 1,
              ),
            ],
          ),
        );
      } else if (_selectedGraphType == 'Linha') {
        return SizedBox(
          width: 150,
          height: 400,
          child: SfCartesianChart(
            title: ChartTitle(
                text: 'Gráfico\n $_selectedData de $_selectedCategory'),
            legend: Legend(
              isVisible: true,
              overflowMode: LegendItemOverflowMode.wrap,
            ),
            tooltipBehavior: TooltipBehavior(
              enable: true,
              format: 'point.x : point.y',
            ),
            series: <ChartSeries>[
              LineSeries<Produto, String>(
                dataSource: filteredData,
                xValueMapper: (Produto data, _) => data.mes,
                yValueMapper: (Produto data, _) => data.valor,
                dataLabelSettings: DataLabelSettings(isVisible: true),
                enableTooltip: true,
                color: Colors.blueGrey.shade300,
                markerSettings: MarkerSettings(
                  isVisible: true,
                  color: Colors.blueGrey.shade300,
                ),
                name: '',
              ),
            ],
            primaryXAxis: CategoryAxis(),
          ),
        );
      } else {
        return SizedBox(
          width: 150,
          height: 400,
          child: SfCartesianChart(
            title: ChartTitle(
                text: 'Gráfico\n $_selectedData de $_selectedCategory'),
            legend: Legend(
              isVisible: true,
              overflowMode: LegendItemOverflowMode.wrap,
            ),
            tooltipBehavior: TooltipBehavior(
              enable: true,
              format: 'point.x : point.y',
            ),
            series: <ChartSeries>[
              ColumnSeries<Produto, String>(
                dataSource: filteredData,
                xValueMapper: (Produto data, _) => data.mes,
                yValueMapper: (Produto data, _) => data.valor,
                dataLabelSettings: DataLabelSettings(isVisible: true),
                enableTooltip: true,
                color: Colors.blueGrey.shade300,
                name: '',
              ),
            ],
            primaryXAxis: CategoryAxis(),
          ),
        );
      }
    } else {
      return Container();
    }
  }

  Future<void> _showMyDialog() async {
    return showDialog<void>(
      context: context,
      barrierDismissible: false,
      builder: (BuildContext context) {
        return AlertDialog(
          title: const Text('Opções não selecionadas'),
          content: const SingleChildScrollView(
            child: ListBody(
              children: <Widget>[
                Text(
                    'Por favor, selecione todas as opções para gerar o gráfico.'),
              ],
            ),
          ),
          actions: <Widget>[
            ElevatedButton.icon(
              icon: Icon(Icons.close),
              label: Text("Fechar"),
              onPressed: () {
                Navigator.of(context).pop();
              },
            ),
          ],
        );
      },
    );
  }
}
