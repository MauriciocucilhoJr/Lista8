using System;
using System.Collections;
using System.Collections.Generic;

namespace Dictinary8
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args is null)
            {
                throw new ArgumentNullException(nameof(args));
            }

            Console.WriteLine("\n Dicionario: Mentalidades e Habilidades.");

            Dictionary<string, string> mentalidades = new()
            {
                { "Mentalidade de Crescimento", new string("Ter uma mentalidade de crescimento é acreditar que suas competências mais básicas podem ser desenvolvidas através de dedicação e trabalho árduo. O cérebro e o talento são apenas o ponto de partida.") },
                { "Mentalidade de Persistência", new string("Ser persistente significa que você continuará tentando vez após vez. Em cada tentativa, você estará mais próximo do sucesso.") },
                { "Mentalidade de Responsabilidade pessoal", new string("Responsabilidade pessoal significa assumir a responsabilidade por suas próprias ações, trabalhando arduamente, mantendo seus compromissos e não dando desculpas.") },
                { "Mentalidade de Orientação ao Futuro", new string("Ter orientação ao futuro significa estabelecer metas para o seu futuro, compreender como as ações de hoje impactam nessas metas e verificar seu progresso com frequência.") }
            };

            Dictionary<string, string> habilidades = new()
            {
                { "Habilidade de Comunicação", new string("Uma boa comunicação significa capacidade de expressar ideias de forma clara e concisa, com linguagem apropriada ao público, assim como ouvir com atençãom, manter contato visual com seus interlocutores e tomar notas ao receber novas informações.") },
                { "Habilidade de Proatividade", new string("Proatividade significa assumir a liderança em seu emprego sem nenhum impulso de seu gerente, antecipando situações e tomando as ações preventivas que forem necessárias.") },
                { "Habilidade de Orientação ao detalhe", new string("Orientação ao detalhe consiste em estar constantemente atento aos detalhes ao executar tarefas, a fim de serem completadas com precisão e cuidado.") },
                { "Habilidade de Trabalho em equipe", new string("Trabalho em equipe Consiste em um trupo de pessoas, ou apenas duas pessoas, trabalhando em conjunto visando um objetivo em comum.") }
            };

            Console.WriteLine("\n As mentalidades da Generation são:");

            foreach (KeyValuePair<string, string> valor in mentalidades)
            {
                Console.WriteLine($"Mentalidade = {valor.Key} | Significado = {valor.Value}");
            }

            Console.WriteLine("\n As habilidade da Generation são:");

            foreach (KeyValuePair<string, string> valor in habilidades)
            {
                Console.WriteLine($"Habilidades = {valor.Key} | Significado = {valor.Value}");
            }


        }
    }
}
