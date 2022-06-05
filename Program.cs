using bytebank_adm.Funcionarios;
using bytebank_adm.ParceriaComercial;
using bytebank_adm.SistemaInterno;
using bytebank_adm.Utilitario;

//CalcularBonificacao();
UsarSistema();

void CalcularBonificacao()
{
    GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();

    Designer pedro = new Designer("833.222.048-39");
    pedro.Nome = "Pedro";

    Desenvolvedor samya = new Desenvolvedor("541.674.891-20");
    samya.Nome = "Samya";

    Diretor paula = new Diretor("159.753.398-04");
    paula.Nome = "Paula";

    Auxiliar igor = new Auxiliar("981.198.778-53");
    igor.Nome = "Igor";

    GerenteDeContas camila = new GerenteDeContas("326.985.628-89");
    camila.Nome = "Camila";

    gerenciador.Registrar(pedro);
    gerenciador.Registrar(paula);
    gerenciador.Registrar(igor);
    gerenciador.Registrar(camila);
    gerenciador.Registrar(samya);

    Console.WriteLine("Total de Bonificação: " + gerenciador.getBonificacao());
}


void UsarSistema()
{
    SistemaInterno sistemainterno = new SistemaInterno();

    Diretor roberta = new Diretor("159.753.398-04");
    roberta.Nome = "Roberta";
    roberta.Senha = "123";

    GerenteDeContas ursula = new GerenteDeContas("326.985.628-89");
    ursula.Nome = "Ursula";
    ursula.Senha = "321";

    //Funcionario pedro = new Designer("326.985.628-89");
    //pedro.Nome = "Pedro";
    //pedro.Senha = "123";

    ParceiroComercial joao = new ParceiroComercial();
    joao.Senha = "123";

    //sistemainterno.Logar(pedro, "123");
    sistemainterno.Logar(roberta, "123");
    sistemainterno.Logar(ursula, "321");
    sistemainterno.Logar(joao, "123");
    
}

Console.ReadKey();
