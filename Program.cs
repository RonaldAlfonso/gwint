// See https://aka.ms/new-console-template for more information
using System;
using System.Drawing;
using System.Formats.Asn1;
using System.Linq.Expressions;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
namespace Gwint{
    public enum Atack{
        cuerpoacuerpo,
        asedio,
        distancia, 
    }
    public enum Faction{
        faccion1,
        faccion2,
        neutral,
    }
    public enum CartType{
        oro,
        plata,
    }
    public enum SpecialsType{
        clima,
        decoy,
        despeje,
        aumento,
    }
    public enum Efects{
        aumentofila,
        ponerclima,
        eliminarmaspoder,
        eliminarmenospoder,
        robarcarta,
        multiplicar,
        limpiafila,
        promedio,
        ninguno,
    }
    public enum LeaderEfects{
        retener,
        roboextra,
    }
    class UnityCard: Card{
        
        public int Power;
        public Atack[] AtackType;
        public CartType Type;
        public Efects Efect;
        
    
        public UnityCard(string name,int power,Atack[] atackType,CartType type,Faction cartFaction,Efects efect){
            Name=name;
            Power=power;
            AtackType=atackType;
            Type=type;
            CartFaction=cartFaction;
            Efect=efect;
             
        }  

    }
    public abstract class Card {
        public string Name;
        public Faction CartFaction;

    }
    public class Leader{
        public string Name;
        public LeaderEfects Efect;
        public Faction CartFaction;
        public Leader(string name,LeaderEfects efect,Faction cardFaction){
            Name=name;
            Efect=efect;
            CartFaction=cardFaction;
        }
    }
    public class Deck{
        public Leader Lider;
        public List<Card>Mazo;


    }
    public class SpecialsCards:Card{
        public SpecialsType Type;
    }

    }        
    

//     class Program{
//         static void Main(){
//             Atack[] re={Atack.cuerpoacuerpo,Atack.asedio};
//            CartType Tipo =CartType.oro;
//            Faction faccion=Faction.faccion2;
//            Efects efecto=Efects.ninguno;
//         Gwint.UnityCard probando=new UnityCard("probando",2,re,Tipo,faccion,efecto);
//         System.Console.WriteLine(probando.Name);
//         System.Console.WriteLine(probando.CartFaction);
//         System.Console.WriteLine(probando.Efect);
//         System.Console.WriteLine(probando.Power);
//         System.Console.WriteLine(probando.Type);
//         for(int i=0;i<probando.AtackType.Length;i++){
//         System.Console.WriteLine(probando.AtackType[i]);
//         }
//         }
//     }
// }

