using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardsDatabase : MonoBehaviour
{
    public static List<Card> cardList = new List<Card> ();

    private void Awake()
    {
        cardList.Add(new Card(0, "Ataque corrosivo", 6, true, "Añade 1 Ataque a tu tirada", Resources.Load<Sprite>("Cards/Acid_attack")));
        cardList.Add(new Card(1, "Extraterrestre", 3, true, "Comprar cartas de poder te cuesta 1 Energía menos", Resources.Load<Sprite>("Cards/Alien_metabolism")));
        cardList.Add(new Card(2, "Monstruo alfa", 5, true, "Ganas 1 Estrella cuando en tu tirada obtienes 1 Ataque como mínimo", Resources.Load<Sprite>("Cards/Alpha_monster")));
        cardList.Add(new Card(3, "Edificio de apartamentos", 5, false, "Gana 3 Estrellas", Resources.Load<Sprite>("Cards/Apartment_building")));
        cardList.Add(new Card(4, "Blindaje", 4, true, "No pierdes Corazones cuando pierdes exactamente 1 Corazón", Resources.Load<Sprite>("Cards/Armor_plating")));
        cardList.Add(new Card(5, "Al acecho", 3, true, "Siempre puedes volver a tirar cualquier 3 que obtengas", Resources.Load<Sprite>("Cards/Background_dweller")));
        cardList.Add(new Card(6, "Excavar", 5, true, "Añade 1 Ataque a tu tirada mientras estés en Tokyo. Cuando huyas de Tokyo, el monstruo que la ocupe pierde 1 Corazón", Resources.Load<Sprite>("Cards/Burrowing")));
        cardList.Add(new Card(7, "Camuflaje", 3, true, "Si pierdes Corazones, lanza un dado por cada Corazón perdido. Cada tirada Corazón reduce la pérdida en 1 Corazón", Resources.Load<Sprite>("Cards/Camouflage")));
        cardList.Add(new Card(8, "Tren de cercanías", 4, false, "Gana 2 Estrellas", Resources.Load<Sprite>("Cards/Commuter_train")));
        cardList.Add(new Card(9, "Destrucción total", 3, true, "Si consigues una tirada de 1, 2, 3, Corazón, Ataque, Energía, ganas 9 Estrellas además de los efectos habituales", Resources.Load<Sprite>("Cards/Complete_destruction")));
        cardList.Add(new Card(10, "Tienda de la esquina", 3, false, "Gana 1 Estrella", Resources.Load<Sprite>("Cards/Corner_store")));
        cardList.Add(new Card(11, "Fama mediática", 3, true, "Ganas 1 Estrella cada vez que compras una carta de poder", Resources.Load<Sprite>("Cards/Dedicated_news_team")));
        cardList.Add(new Card(12, "Caído del cielo", 5, false, "Gana 2 Estrellas y entra en Tokyo si todavía no lo controlas", Resources.Load<Sprite>("Cards/Drop_from_high_altitude")));
        cardList.Add(new Card(13, "Devorador de cadáveres", 4, true, "Ganas 3 Estrellas cada vez que los corazones de un monstruo quedan a 0", Resources.Load<Sprite>("Cards/Eater_of_the_dead")));
        cardList.Add(new Card(14, "Recargar", 8, false, "Gana 9 Energía", Resources.Load<Sprite>("Cards/Energize")));
        cardList.Add(new Card(15, "Bebida energética", 4, true, "Gasta 1 Energía para obtener un lanzamiento de dados adicional", Resources.Load<Sprite>("Cards/Energy_drink")));
        cardList.Add(new Card(16, "Acumulador de energía", 3, true, "Ganas 1 Estrella por cada 6 Energía que tengas al final de tu turno", Resources.Load<Sprite>("Cards/Energy_hoarder")));
        cardList.Add(new Card(17, "Órdenes de evacuación", 7, false, "Todos los demás monstruos pierden 5 Estrellas", Resources.Load<Sprite>("Cards/Evacuation_orders")));
        cardList.Add(new Card(18, "Órdenes de evacuación", 7, false, "Todos los demás monstruos pierden 5 Estrellas", Resources.Load<Sprite>("Cards/Evacuation_orders")));
        cardList.Add(new Card(19, "Colosal", 4, true, "Ganas 2 corazones al comprar esta carta. Mientras tengas esta carta, tu máximo de Corazones se incrementa a 12", Resources.Load<Sprite>("Cards/Even_bigger")));
        cardList.Add(new Card(20, "Cabeza adicional", 7, true, "Obtienes 1 dado adicional", Resources.Load<Sprite>("Cards/Extra_head")));
        cardList.Add(new Card(21, "Cabeza adicional", 7, true, "Obtienes 1 dado adicional", Resources.Load<Sprite>("Cards/Extra_head")));
        cardList.Add(new Card(22, "Lanzallamas", 3, false, "Todos los demás monstruos pierden 2 Corazones", Resources.Load<Sprite>("Cards/Fire_blast")));
        cardList.Add(new Card(23, "Aliento flamígero", 4, true, "Tus vecinos pierden 1 Corazón cuando en tu tirada obtienes al menos 1 Ataque", Resources.Load<Sprite>("Cards/Fire_breathing")));
        cardList.Add(new Card(24, "Tiempo congelado", 5, true, "En un turno que obtengas una tirada de triple 1 o superior, puedes jugar otro turno con un dado menos", Resources.Load<Sprite>("Cards/Freeze_time")));
        cardList.Add(new Card(25, "Frenesí", 7, false, "Dispones de otro turno después de éste", Resources.Load<Sprite>("Cards/Frenzy")));
        cardList.Add(new Card(26, "Amigo de los niños", 3, true, "Cuando obtienes Energía, ganas 1 energía adicional", Resources.Load<Sprite>("Cards/Friend_of_children")));
        cardList.Add(new Card(27, "refinería de gas", 6, false, "Gana 2 Estrellas y todos los demás monstruos pierden 3 Corazones", Resources.Load<Sprite>("Cards/Gas_refinery")));
        cardList.Add(new Card(28, "Cerebro gigante", 5, true, "Dispones de 1 lanzamiento de dados adicional cada turno", Resources.Load<Sprite>("Cards/Giant_brain")));
        cardList.Add(new Card(29, "Gourmet", 4, true, "Si consigues una tirada de triple 1 o superior, ganas 2 Estrellas adicionales", Resources.Load<Sprite>("Cards/Gourmet")));
        cardList.Add(new Card(30, "Curar", 3, false, "Gana 2 Corazones", Resources.Load<Sprite>("Cards/Heal")));
        cardList.Add(new Card(31, "Rayo Sanador", 4, true, "Puedes usar tus dados Corazones, para que otros monstruos ganen Corazones. Cada monstruo debe pagar 2 Energía (o 1 energía si no le quedan más) por cada Corazón obtenido de este modo", Resources.Load<Sprite>("Cards/Healing_ray")));
        cardList.Add(new Card(32, "Herbívoro", 5, true, "Si al final de tu turno no has causado ninguna pérdida de Corazón, ganas 1 Estrella", Resources.Load<Sprite>("Cards/Herbivore")));
        cardList.Add(new Card(33, "Exterminio selectivo", 3, true, "Puedes cambiar uno de tus dados por un 1 cada turno", Resources.Load<Sprite>("Cards/Herd_culler")));
        cardList.Add(new Card(34, "Bombardeo estratégico", 4, false, "Todos los monstruos (incluido el tuyo) pierden 3 Corazones", Resources.Load<Sprite>("Cards/High_altitude_bombing")));
        cardList.Add(new Card(35, "¡Tiene un cachorro!", 7, true, "Si llegas a 0 Corazones, descartas todas tus cartas y puerdes todas tus estrellas. Ganas 10 Corazones y sigues jugando fuera de Tokyo", Resources.Load<Sprite>("Cards/It_has_a_child")));
        cardList.Add(new Card(36, "Cazas de combate", 5, false, "Gana 5 Estrellas y recibe 4 de daño", Resources.Load<Sprite>("Cards/Jet_fighters")));
        cardList.Add(new Card(37, "Propulsores", 5, true, "No pierdes Corazones si decide huir de Tokyo", Resources.Load<Sprite>("Cards/Jets")));
        cardList.Add(new Card(38, "Monstruo Probeta", 2, true, "En la fase de compra de cartas de poder, puedes mirar la carta superior del mazo y comprarla, o volver a dejarla sobre el mazo", Resources.Load<Sprite>("Cards/Made_in_a_lab")));
        cardList.Add(new Card(39, "Metamorfo", 3, true, "Al final de tu turno, puedes descartar cualesquiera de las cartas PERMANENTE que tienes para ganar su coste completo en Energía", Resources.Load<Sprite>("Cards/Metamorph")));
        cardList.Add(new Card(40, "Mimetismo", 8, true, "Elige una carta de tipo PERMANENTE que cualquier monstruo tenga en juego y colócale una ficha de Mimetismo. Esta carta es un duplicado de aquella como si la acabaras de comprar. Gasta 1 Energía al iniciar tu turno para mover la ficha de Mimetismo y cambiar la carta que quieres imitar", Resources.Load<Sprite>("Cards/Mimic")));
        cardList.Add(new Card(41, "Monstruo pila", 3, true, "Cuando compras al MOnstruo Pila, colócale encima 6 Energía de la banca. Al iniciarse cada turno, quítale 2 Energía y añadelos a tu reserva. Descarta esta carta cuando se quede sin Energía", Resources.Load<Sprite>("Cards/Monster_batteries")));
        cardList.Add(new Card(42, "Guardia Nacional", 3, false, "Gana 2 Estrellas y pierde 2 Corazones", Resources.Load<Sprite>("Cards/National_guard")));
        cardList.Add(new Card(43, "Aliento nova", 7, true, "Tus Ataques atacan a todos los demás monstruos", Resources.Load<Sprite>("Cards/Nova_breath")));
        cardList.Add(new Card(44, "Central nuclear", 6, false, "Gana 2 Estrellas y cura 3 Corazones", Resources.Load<Sprite>("Cards/Nuclear_power_plant")));
        cardList.Add(new Card(45, "Basurívoro", 4, true, "Si en tu tirada obtienes al menos 1, 2 y 3, ganas 2 Estrellas. También puedes usar esos dados en otras combinaciones", Resources.Load<Sprite>("Cards/Omnivore")));
        cardList.Add(new Card(46, "Oportunista", 3, true, "Siempre que se revela una carta de poder, tienes la opción de comprarla inmediatamente", Resources.Load<Sprite>("Cards/Opportunist")));
        cardList.Add(new Card(47, "Tentáculos parasitarios", 4, true, "Puedes comprar las cartas de poder de otros monstruos. Págales el coste de Energía", Resources.Load<Sprite>("Cards/Parasitic_tentacles")));
        cardList.Add(new Card(48, "Golpe de efecto", 3, true, "Antes de resolver tus dados, puedes cambiar el resultado de un dado. Descarta esta carta cuando la utilices", Resources.Load<Sprite>("Cards/Plot_twist")));
        cardList.Add(new Card(49, "Puás Venenosas", 3, true, "Si consigues una tirada de triple 2 o superior, añade 2 ataques a tu tirada", Resources.Load<Sprite>("Cards/Poison_quills")));
        cardList.Add(new Card(50, "Escupir Veneno", 4, true, "Cada monstruo que ataques con tus Ataques recibe 1 ficha de Veneno. Al finalizar sus turnos, los monstruos pierden 1 Corazón por cada ficha de Veneno que tengan. Una ficha de Veneno se puede eliminar usando una tirada Corazón en lugar de ganar 1 Corazón", Resources.Load<Sprite>("Cards/Poison_spit")));
        cardList.Add(new Card(51, "Sondeo psíquico", 3, true, "Puedes volver a lanzar un dado a tu elección después de que los demás monstruos hayan completado su tirada. Si vuelves a lanzar un Corazón, descarta esta carta", Resources.Load<Sprite>("Cards/Psychic_probe")));
        cardList.Add(new Card(52, "Curación Rápida", 3, true, "Gasta 2 de energía en cualquier momento para ganar 1 corazón", Resources.Load<Sprite>("Cards/Rapid_healing")));
        cardList.Add(new Card(53, "Regeneración", 4, true, "Cuando obtienes corazón, ganas 1 corazón extra", Resources.Load<Sprite>("Cards/Regeneration")));
        cardList.Add(new Card(54, "Asistencia al necesitado", 3, true, "Al final de tu turno, si tienes la menor cantidad de Estrellas, ganas 1 Estrella", Resources.Load<Sprite>("Cards/Rooting_for_the_underdog")));
        cardList.Add(new Card(55, "Rayo reductor", 6, true, "Cada monstruo que ataques con tus Ataques recibe 1 ficha de Reducción. Al iniciar sus turnos, los monstruos lanzan 1 dado menos por cada ficha de Reducción que tengan. Una ficha de Reducción se puede eliminar usando una tirada Corazón en lugar de ganar 1 Corazón", Resources.Load<Sprite>("Cards/Shrink_ray")));
        cardList.Add(new Card(56, "Rascacielos", 6, false, "Gana 4 Estrellas", Resources.Load<Sprite>("Cards/Skyscraper")));
        cardList.Add(new Card(57, "Nube de humo", 4, true, "Coloca 3 fichas de humo en esta carta. Gasta 1 ficha de humo para conseguir un lanzamiento adicional. Descarta esta carta cuando se hayan gastado todas las fichas de humo", Resources.Load<Sprite>("Cards/Smoke_cloud")));
        cardList.Add(new Card(58, "Carga Solar", 2, true, "Al final de tu turno ganas 1 Energía si no tienes Energía", Resources.Load<Sprite>("Cards/Solar_powered")));
        cardList.Add(new Card(59, "Cola de púas", 5, true, "Si obtienes 1 Ataque como mínimo, añade 1 Ataque a tu tirada", Resources.Load<Sprite>("Cards/Spiked_tail")));
        cardList.Add(new Card(60, "Elástico", 3, true, "Antes de resolver tus dados, puedes gastar 2 Energía para cambiar el resultado de uno de tus dados", Resources.Load<Sprite>("Cards/Stretchy")));
        cardList.Add(new Card(61, "Tanques", 4, false, "Gana 4 Estrellas y recibes 3 de daño", Resources.Load<Sprite>("Cards/Tanks")));
        cardList.Add(new Card(62, "Urbívoro", 4, true, "Ganas 1 Estrella adicional si empiezas tu turno en Tokyo. Si estás en Tokyo y obtienes un Ataque como mínimo, añade un Ataque a tu tirada", Resources.Load<Sprite>("Cards/Urbavore")));
        cardList.Add(new Card(63, "Gran Tormenta", 6, false, "Gana 2 estrella y todos los demás monstruos pierden 1 Energía por cada 2 Energía que tengan", Resources.Load<Sprite>("Cards/Vast_storm")));
        cardList.Add(new Card(64, "¡Se hace más fuerte!", 3, true, "Cuando pierdes 2 Corazones o más, ganas 1 Energía", Resources.Load<Sprite>("Cards/We_are_making_it_stronger")));
        cardList.Add(new Card(65, "Alas", 6, true, "Gasta 2 Energía para no perder Corazones durante este turno", Resources.Load<Sprite>("Cards/Wings")));






        for (int i = 0; i < cardList.Count; i++)
        {
            Debug.Log("Card: " + cardList[i].id);
            Debug.Log("Name: " + cardList[i].name);
            Debug.Log("Cost: " + cardList[i].cost);
            Debug.Log("Keep: " + cardList[i].keep.ToString());
            Debug.Log("Description: " + cardList[i].description);
        }
    }

    public void Start()
    {
        //for (int i = 0; i < cardlist.count; i++)
        //{
        //    debug.log("card: " + cardlist[i].id);
        //    debug.log("name: " + cardlist[i].name);
        //    debug.log("cost: " + cardlist[i].cost);
        //    debug.log("keep: " + cardlist[i].keep.tostring());
        //    debug.log("description: " + cardlist[i].description);
        //}
    }

}
