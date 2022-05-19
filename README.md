Mudanças no projeto:

* Implementadas as classes "Ninja" e "Black Wizard".

* Cada classe recebeu um método CalculateHP() que calcula os pontos de vida do personagem com base no seu nível e um modificador próprio da classe e um método CalculateMP() que faz o mesmo para os pontos de mana.

* Os métodos Attack(), CalculateHP() e CalculateMP() da classe abstrata Hero foram declarados como abstratos para cada classe filha poder implementar.

* O construtor de personagens não recebe mais uma string HeroType, já que cada tipo de herói usa seu próprio construtor.

* O método para imprimir os personagens foi modificado para ficar mais parecido com a interface do game.
