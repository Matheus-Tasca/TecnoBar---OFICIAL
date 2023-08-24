class BasicTile {
  final String title;
  final List<BasicTile> tiles;

  const BasicTile({
    required this.title,
    this.tiles = const [],
  });
}

final basicTiles = <BasicTile>[
  BasicTile(title: 'Tempo', tiles: [
    BasicTile(title: '1 Dia'),
    BasicTile(title: '7 Dias'),
    BasicTile(title: '30 Dias'),
  ])];

/*List<BasicTile> buildMonths() => [
      'January',
      'February',
      'March',
      'April',
      'November',
      'December',
    ].map<BasicTile>(buildMonth).toList();

BasicTile buildMonth(String month) => BasicTile(
    title: month,
    tiles: List.generate(28, (index) => BasicTile(title: '$index.')));*/
