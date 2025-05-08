Nome:
Victor hugo wille
Mateus Scalabrin Neinas 
Bruno Henrique Oliveira Garcia Gouvea

Seminário: Programação Orientada a Objetos com C#

Este repositório contém o código desenvolvido para o seminário sobre Validação de Regras de Negócio e Uso de Propriedades na Programação Orientada a Objetos com C#. Abaixo estão os detalhes dos principais conceitos abordados no código.

Regras de Negócio
As Regras de Negócio são condições, restrições ou diretrizes que definem como um processo de negócio deve funcionar. Elas representam o conhecimento e as políticas da organização, sendo essenciais para garantir que o sistema siga os objetivos e limites do negócio.

Encapsulamento é um dos pilares da Programação Orientada a Objetos e consiste em proteger os dados internos de uma classe contra acessos indevidos.

Como Funciona
As variáveis (atributos) são privadas.

O acesso a elas é feito apenas por métodos públicos, permitindo controlar e validar os dados.

Propriedades
Propriedades são membros de uma classe que fornecem acesso controlado a campos privados. Elas encapsulam o campo, permitindo que o programador controle a leitura e escrita dos dados de forma segura. As propriedades são declaradas com { get; set; }.

Construtores
Um Construtor é um método especial de uma classe que é chamado automaticamente quando o objeto é criado. Ele serve para inicializar o objeto e garantir que ele comece em um estado válido.

Objetivos e Boas Práticas
Validação centralizada: Toda regra de negócio deve estar encapsulada na própria entidade ou objeto de valor.

Uso de private set em propriedades críticas: Protege o estado interno do objeto, permitindo alterações apenas por métodos controlados ou no construtor.

Separação entre lógica de apresentação e lógica de negócio: A camada de UI não deve conter lógica de domínio.

Conclusão
Este repositório foi desenvolvido com o objetivo de demonstrar boas práticas de Programação Orientada a Objetos utilizando C#, incluindo o uso de Regras de Negócio, Encapsulamento, Propriedades e Construtores. O código segue os princípios de encapsulamento e validação para garantir que o estado do objeto seja controlado e consistente, de acordo com as regras de negócio especificadas.

