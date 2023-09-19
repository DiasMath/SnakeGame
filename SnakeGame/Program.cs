using SnakeGame;

const int larguraTela = 69;
const int alturaTela = 29;
const string caractereCobra = "■";

string[,] tela = new string[larguraTela, alturaTela];
bool jogoRodando = true;
List<Coordenada> coordenadasCobra = new();

Direcao direcao = Direcao.Direita;
int placar = 0;
Random random = new();