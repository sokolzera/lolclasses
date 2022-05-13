using LolClasses;

//stwórz nowego champa - garena
Garen g = new Garen();
//opdal emotke dla garena
g.ctrl3();

//stworz instacje przedmiotu - rubycrystal
BFSword bf = new BFSword();
//sprawdz ile ma hp garen
g.showAD();
//kup mu item
g.buyItem(bf);
//sprawdz ile ma teraz hp
g.showAD();
//kup mu drugi item
g.buyItem(bf);
//sprawdz ile ma teraz hp
g.showAD();






