using LolClasses;

//stwórz nowego champa - garena
Garen g = new Garen();
Bard b = new Bard();
//opdal emotke dla garena
g.ctrl3();

//stworz instacje przedmiotu - rubycrystal
RubyCrystal rb = new RubyCrystal();
Rabadon rd = new Rabadon();
BFSword bfs = new BFSword();
//sprawdz ile ma hp garen
g.showHP();
g.showAD();
//kup mu item
g.buyItem(rb);
//sprawdz ile ma teraz hp
g.showHP();
//kup mu drugi item
g.buyItem(rb);
//sprawdz ile ma teraz hp
g.showHP();
g.buyItem(bfs);
g.showAD();
b.buyItem(rd);
b.showAP();
b.Q(g);






