﻿using DotNetFloripa.Model;
using DotNetFloripa.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetFloripa.Data
{
    public class AppRepository : IAppRepository
    {
        public AppRepository()
        {
            Events = new[]{
                new Event {
                    Id = 1,
                    Slug = "dotnetfloripa-fevereiro",
                    Description = "O grupo DotNetFloripa está voltando a ativa e já temos um novo evento marcado!",
                    Start = new DateTime(2014,2,19,19,00,0),
                    End = new DateTime(2014,2,19,21,30,0),
                    EventickId = 4846,
                    EventickUrl = "http://www.eventick.com.br/dotnetfloripa-fevereiro",
                    ImageUrl = "http://i.imgur.com/2ls3CgF.png",
                    Organizers = new[]{"André Carlucci", "Renato Haddad", "Luís Deschamps Rudge"},
                    Title = "dotnet Floripa - Fevereiro",
                    Talks = new[]{ 
                        new Talk { 
                            Description = "NancyFX é um framework HTTP super leve que serve de alternativa para o ASP.NET MVC ou ASP.NET Web API. Por que precisamos de uma alternativa? Quais os benefícios que isso traz e como introduzir o NancyFX em um app já existente? Venha conferir!",
                            Start = new DateTime(2014,2,19,19,30,0),
                            End = new DateTime(2014,2,19,20,15,0),
                            Speaker = "Luís Deschamps Rudge",
                            Title = "Conheça o NancyFX!"
                        },new Talk { 
                            Start = new DateTime(2014,2,19,20,15,0),
                            End = new DateTime(2014,2,19,20,30,0),
                            Title = "coffee-break",
                            Description = "Sim! Agora temos coffee-break com deliciosos salgadinhos!"
                        },new Talk { 
                            Description = "Todos nós amamos o Nuget. É até difícil lembrar o quanto era cruel gerenciar nossas dependências de projetos manualmente. Nesta palestra damos um passo a mais: vamos aprender como criar nossos próprios pacotes, integrá-los com builds automatizados e descobrir como sua empresa pode tirar o máximo desta tecnologia.",
                            Start = new DateTime(2014,2,19,20,30,0),
                            End = new DateTime(2014,2,19,21,30,0),
                            Speaker = "André Carlucci",
                            Title = "Aproveite ao máximo o Nuget"
                        }
                    }
                },
                new Event {
                    Id = 2,
                    Slug = "gwab-floripa",
                    Description = "Bootcamp de Windows Azure! Mais informações no <a href='http://gwab2014-floripa.azurewebsites.net/'>site oficial</a>! ",
                    Start = new DateTime(2014,3,29,8,0,0),
                    End = new DateTime(2014,3,29,17,0,0),
                    EventickId = 0,
                    EventickUrl = "http://www.eventick.com.br/GWAB2014-Florianopolis-SC",
                    ImageUrl = "http://i.imgur.com/yW4p5Yy.jpg",
                    Organizers = new[]{"André Carlucci", "Luís Deschamps Rudge"},
                    Title = "Global Windows Azure Bootcamp - Floripa",
                    Talks = new[]{ 
                        new Talk { 
                            Description = "Boas vindas",
                            Start = new DateTime(2014,3,29,8,0,0),
                            End = new DateTime(2014,3,29,8,30,0),
                            Speaker = "-",
                            Title = "Welcome"
                        },new Talk { 
                            Description = "Keynote sobre o evento",
                            Start = new DateTime(2014,3,29,8,30,0),
                            End = new DateTime(2014,3,29,9,0,0),
                            Speaker = "-",
                            Title = "Keynote Microsoft"
                        },new Talk { 
                            Description = "Overview sobre Windows Azure",
                            Start = new DateTime(2014,3,29,9,0,0),
                            End = new DateTime(2014,3,29,9,45,0),
                            Speaker = "Luís Deschamps Rudge",
                            Title = "Overview Windows Azure"
                        },new Talk { 
                            Description = "LAB",
                            Start = new DateTime(2014,3,29,9,45,0),
                            End = new DateTime(2014,3,29,11,0,0),
                            Speaker = "-",
                            Title = "Lab: Luta contra diabetes"
                        },new Talk { 
                            Description = "Entenda o que é Azure Mobile Services e como utilizá-lo com sucesso no seu app!",
                            Start = new DateTime(2014,3,29,11,0,0),
                            End = new DateTime(2014,3,29,11,30,0),
                            Speaker = "André Carlucci",
                            Title = "Windows Azure Mobile Services"
                        },new Talk { 
                            Description = "Confira como utilizar o Azure como uma extensão da sua empresa!",
                            Start = new DateTime(2014,3,29,11,30,0),
                            End = new DateTime(2014,3,29,12,0,0),
                            Speaker = "Luís Deschamps Rudge",
                            Title = "Máquinas virtuais e VPN"
                        },new Talk { 
                            Description = "Almoço grátis no local",
                            Start = new DateTime(2014,3,29,12,0,0),
                            End = new DateTime(2014,3,29,13,0,0),
                            Speaker = "-",
                            Title = "Almoço"
                        },new Talk { 
                            Description = "LAB",
                            Start = new DateTime(2014,3,29,13,0,0),
                            End = new DateTime(2014,3,29,16,45,0),
                            Speaker = "-",
                            Title = "Labs (Virtual Machines, VPN, Mobile Services, WebSites)"
                        },new Talk { 
                            Description = "Encerramento",
                            Start = new DateTime(2014,3,29,16,45,0),
                            End = new DateTime(2014,3,29,17,0,0),
                            Speaker = "-",
                            Title = "Encerramento"
                        }
                    }
                },
                new Event {
                    Id = 3,
                    Slug = "dotnetfloripa-2015-04",
                    Description = "IoT com Netduíno e reconhecimento de gestos com RealSense",
                    Start = new DateTime(2015,4,23,19,15,0),
                    End = new DateTime(2014,4,23,21,15,0),
                    EventickId = 4846,
                    EventickUrl = "http://even.tc/dotnetfloripa-2015-04",
                    ImageUrl = "http://i.imgur.com/2ls3CgF.png",
                    Organizers = new[]{"André Carlucci", "Renato Haddad", "Luís Deschamps Rudge"},
                    Title = "dotnet Floripa - Abril de 2015",
                    Talks = new[]{
                        new Talk {
                            Description = "Você já deve ter ouvido falar disso. Internet das Coisas (IoT Internet of things), tudo o que é dispositivo pessoal ou equipamento com um endereço IP, sendo monitorado, gerenciado e telemetrado. Mas que tal começar a colocar a mão na massa e entender como interagir com os dispositivos por exemplo Chaves de contato liga e desliga, medidores de potência, leds, tudo isso usando MicroFrameWork + Arduino = NetDuino em C#!!! Assista esta palestra e saia com o lado esquerdo do cérebro pipocando de ideias.",
                            Start = new DateTime(2015,4,23,19,15,0),
                            End = new DateTime(2015,4,23,20,00,0),
                            Speaker = "Claudenir C. Andrade",
                            Title = "IOT Internet das Coisas Visual Studio e Windows embedded"
                        },new Talk {
                            Start = new DateTime(2015,4,23,20,0,0),
                            End = new DateTime(2015,4,23,20,15,0),
                            Title = "coffee-break",
                            Description = "Coffee-break e networking"
                        },new Talk {
                            Description = "Venha aprender como utilizar gestos, fala e expressões faciais para interagir com suas aplicações adicionando a elas um controle natural e intuitivo com Intel RealSense SDK",
                            Start = new DateTime(2015,4,23,20,30,0),
                            End = new DateTime(2015,4,23,21,15,0),
                            Speaker = "André Carlucci e Renato Haddad",
                            Title = "Interaja naturalmente com suas aplicações utilizando o Intel RealSense SDK"
                        }
                    }
                },
                new Event {
                    Id = 4,
                    Slug = "dotnetfloripa-2015-05",
                    Description = "ASP.NET 5 e o novo mundo de desenvolvimento WEB",
                    Start = new DateTime(2015,5,27,19,15,0),
                    End = new DateTime(2014,5,27,21,15,0),
                    EventickId = 16050,
                    EventickUrl = "http://even.tc/dotnetfloripa-2015-05",
                    ImageUrl = "http://i.imgur.com/2ls3CgF.png",
                    Organizers = new[]{"André Carlucci", "Renato Haddad", "Luís Deschamps Rudge"},
                    Title = "dotnet Floripa - Maio de 2015",
                    Talks = new[]{
                        new Talk {
                            Description = "Venha conhecer o que há de novo no ASP.NET 5, os novos tipos e estruturas de projetos, as ferramentas de edição  de códigos, as plataformas de execução de uma aplicação ASP 5 (Windows, Mac Ox, Linux), os arquivos de configurações, a integração com injeção de dependências, os novos .NET Execution Environment (DNX) e .NET Version Manager (DNVM), como integrar com o Entity Framework 7, e ao final, como executar uma aplicação ASP.NET 5 no Pen-Drive.",
                            Start = new DateTime(2015,5,27,19,15,0),
                            End = new DateTime(2015,5,27,20,00,0),
                            Speaker = "Renato Haddad",
                            Title = "O que há de novo no ASP.NET 5?"
                        },new Talk {
                            Start = new DateTime(2015,5,27,20,0,0),
                            End = new DateTime(2015,5,27,20,15,0),
                            Title = "coffee-break",
                            Description = "Coffee-break e networking"
                        },new Talk {
                            Description = "NodeJS, NPM, gulp, yeoman, bower, docker... É tanta coisa nova que é difícil saber por onde começar. Nessa palestra, vamos entender onde cada peça se encaixa e como tirar vantagem de tudo isso utilizando a plataforma .NET",
                            Start = new DateTime(2015,5,27,20,30,0),
                            End = new DateTime(2015,5,27,21,15,0),
                            Speaker = "Luís Deschamps Rudge",
                            Title = "Desenvolvimento WEB moderno com .NET"
                        }
                    }
                }
            };

            Companies = new[] {
                new Company {
                    Name = "Way2 Techonology",
                    Description = "A Way2 desenvolve softwares e serviços para telemedição e gestão de dados de medição de energia. Sediada em Florianópolis, Santa Catarina, a empresa possui uma equipe multidisciplinar especializada no atendimento às demandas de empresas do setor elétrico, como geradoras, transmissoras, distribuidoras e comercializadoras.",
                    Site = "http://way2.com.br",
                    Address = "Rodovia SC 401, Km 04, Espaço Primavera Garden - Bloco B",
                    LogoUrl = "http://i.imgur.com/Slsbsu1.png"
                }
            };
        }
        public Event[] Events { get; private set; }
        public Company[] Companies { get; set; }
        public IQueryable<Event> GetEvents()
        {
            return Events.AsQueryable();
        }
        public Event GetEventBySlug(string slug)
        {
            return Events.FirstOrDefault(e => e.Slug.Equals(slug, StringComparison.InvariantCultureIgnoreCase));
        }
        public IQueryable<Company> GetCompanies()
        {
            return Companies.AsQueryable();
        }
    }
}
