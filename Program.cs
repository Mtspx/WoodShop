using WoodShop.models;

Usuario usuario = new Usuario("Mateus","52147852314","719999999","Rua joao jose rescala");

Movel movel = new Movel("Mesa","Preta","70x80x90","Madeira","www.google.com/image/cadeira-preta");

Funcionario funcionario = new Funcionario("Francisleide","854125632541","7199999999","rua senai cimatec");


Console.WriteLine(movel.Status); // APÓS CADASTRO DO MOVEL STATUS DEFINIDO PARA SOLICITADO
Console.WriteLine(funcionario.Disponivel); // APÓS CADASTRO DO FUNCIONARIO STATUS DEFINIDO PARA DISPONIVEL

movel.AssociarFuncionario(funcionario);

Console.WriteLine(movel.Status); // DEMOSTRANDO QUE O STATUS DO MOVEL FOI MODIFICADO PARA EM ANDAMENTO
Console.WriteLine(funcionario.Disponivel); // DEMOSTRANDO QUE O STATUS DO FUNCIONARIO FOI MODIFICADO PARA INDISPONIVEL

Pagamento pagamento = new Pagamento(movel,300,5);
pagamento.FecharPedido(movel,funcionario);

Console.WriteLine(movel.Status); // APÓS O PAGAMENTO STATUS DO MOVEL MOFICADO PARA ENTREGUE
Console.WriteLine(funcionario.Disponivel); // APÓS PAGAMENTO FUNCIONARIO DISPONIVEL