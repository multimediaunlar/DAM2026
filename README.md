### Dinosaur park
# :palm_tree::t-rex: Dinosaur-Park-Juego2D :t-rex::palm_tree:
- Este es un proyecto para la catedra Desarrollo de Aplicaciones Multimediales, de la carrera Lic. en Diseño y Produccion Multimedia. (Dictada por Patricio Pedersoli)


# Game Design Document (GDD)
![ ](http://www.gameart2d.com/uploads/3/0/9/1/30917885/7726617.jpg " ")



- [Especificaciones técnicas](#Especificaciones-técnicas)
- [Como se juega](#Como-se-juega)
 - [Sinopsis](#Sinopsis)
 - [Elementos del juego](#Elementos-del-juego)
 - [Niveles del juego](#Niveles-del-juego)
 - [Control de los jugadores](#Control-de-los-jugadores)
 - [Victoria](#Victoria)
 - [Derrota](#Derrota)
 - [Fin](#Fin)
 - [Por qué es divertido este juego](#Por-qué-es-divertido-este-juego)
 - [Características claves](#Características-claves)
- [Documento de diseño](#Documento-de-diseño)
 - [Guía de diseño](#Guía-de-diseño)
 - [Definiciones de diseño del juego](#Definiciones-de-diseño-del-juego)
 - [Victoria (Cómo Ganar)](#Victoria (Cómo-Ganar))
 - [Derrota (Cómo Perder)](#Derrota (Cómo Perder))
 - [Transiciones entre Niveles](#Transiciones-entre-Niveles)
 - [Fracaso del Nivel](#Fracaso-del-Nivel)
 - [Enfoque Principal del Juego](#Enfoque-Principal-del-Juego)
 - [Diagrama de flujo del juego](#Diagrama-de-flujo-del-juego)
 - [Definicion de jugador](#Definicion-de-jugador)
 - [Propiedades del jugador](#Propiedades-del-jugador)
 - [User interface UI](#User-interface-UI)
 - [Responsables](#Responsables)
 - [Enlaces de interes](#Enlaces-de-interes)
 - [Colaboradores](#Colaboradores)
 - [Autores](#Autores)


------------
|           |           |           
|-----------|-----------|
| Nombre del Juego    | Dinosaur Park    | 
|  Genero   | Aventura    | 
| Modalidad (jugadores)  | Un jugador (Single Player)    |

------------

## Especificaciones técnicas

- View: Scrolling continuo (Vision lateral)
- Plataforma: Pc
- Lenguaje: C#
- Dispositivo: PC
- Motor de juego: Unity
- Herramientas: Visual studio Code, Illustrator, Photoshop y Audition (Entre otras).
- Recursos gráficos: Sprites, fondos, animaciones, Iconos UI, marcadores, elementos.
- Formulario técnico: Gráficos 2D


## Como se juega
En este emocionante juego 2D, te embarcarás en una trepidante aventura como el intrépido cazador James, quien se encuentra en medio de una exuberante selva. Tu misión es llegar con vida a tu campamento mientras enfrentas innumerables desafíos. En tu camino, deberás cruzar y esquivar trampas naturales, todo mientras te enfrentas a feroces dinosaurios terrestres y aéreos que harán todo lo posible por detenerte. Equipado con un arma de fuego y un cuchillo, tendrás que defender tu vida enfrentando a estas criaturas prehistóricas. Cada golpe de un dinosaurio te quitará un valioso 10% de tu salud, por lo que deberás cuidar de ellos a lo largo del camino para mantener tu resistencia y así llegar al objetivo. ¡Supera este nivel y estarás listo para adentrarte en un nuevo escenario lleno de desafíos aún más intensos en tu búsqueda de supervivencia y aventura!

## Sinopsis
Un valiente cazador, ajeno al asombroso secreto que alberga la densa selva, se ve atrapado entre dinosaurios gigantes. Sin conocimiento previo, deberá abrirse paso a través de distintos obstáculos, enfrentándose a desafíos salvajes y criaturas ancestrales. Armado solo con un arma de fuego, un cuchillo y su ingenio, el cazador debe superar los impedimentos mortales, evadir a depredadores dinosaurios y esquivar objetos para regresar a salvo a su campamento. ¿Podrás guiar al cazador a través de esta odisea llena de peligros y descubrimientos asombrosos en este apasionante juego?

## Elementos del juego
1. El cazador James como personaje principal
2. Dinosaurios terrestres y aéreos
3. Selvas 
4. Armas para el cazador
5. Obstáculos
6. Bonus de vida
7. Foley y banda sonora


## Niveles del juego
**Nivel 1: Entrada a lo desconocido**:
Te encuentras en medio de la selva, sin sospechar la extraordinaria aventura que aguarda. A medida que avanzas, te encuentras con dinosaurios de comportamiento amigable, pero tu intuición te indica que algo mas grande se avecina, tu objetivo de llegar al campamento puede volverse un poco dificultoso.

**Nivel 2: Las bestias Prehistóricas**:
Ahora consiente de la magnitud de lo peligroso, el cazador se aventura mas profundamente en la selva. Este nivel presenta un entorno más complejo. 
Los dinosaurios ahora son todo un desafío a superar. Se incorporan enemigos mas grandes y astutos. A medida que avanzas en el nivel, la intensidad aumenta.
Este nivel termina en una victoria triunfal o en la derrota a la majestuosidad y peligro de la selva.

## Control de los jugadores
En Dinosaur Park, los jugadores asumen el control de Jame, el protagonista, en un vibrante mundo bidimensional repleto de dinosaurios, desafiantes obstáculos y elementos interactivos. El juego permite a los jugadores dirigir a Jame hacia la izquierda o derecha, realizar saltos estratégicos y agacharse para sortear los diversos desafíos. A lo largo de su travesía, los jugadores tienen la oportunidad de recolectar vidas adicionales que serán clave para enfrentar los peligros del parque.

La misión de los jugadores es navegar hábilmente a través de los niveles, esquivando obstáculos y enfrentándose a enemigos dinosaurios para llegar al ansiado campamento al final de cada etapa. El uso hábil del teclado se convierte en la herramienta indispensable para superar los desafíos y avanzar en este fascinante juego.

## Victoria
Se mostrará el siguiente mensaje “¡Felicidades, intrépido cazador! Has superado todos los desafíos de Dinosaur Park y te has convertido en un maestro de la selva prehistórica".

## Derrota
Se mostrará el siguiente mensaje “¡Oh no! Has caído en la selva, prepárate para enfrentar nuevamente los desafíos de Dinosaur Park".

## Fin
“Fin de la expedición en Dinosaur Park".

## Por qué es divertido este juego
Este juego destaca por su ambientación emocionante en una selva repleta de dinosaurios, ofreciendo una experiencia llena de desafíos que mantendrán a los jugadores completamente inmersos. A medida que avanzas en el juego, la intensidad y la adrenalina aumentan de manera progresiva, manteniendo la emoción en cada momento. Además, la cautivadora banda sonora añade una capa adicional de inmersión, haciendo que la experiencia sea aún más envolvente. ¿Estás preparado para embarcarte en esta emocionante aventura y ayudar a Jame a superar todos los obstáculos? ¡La selva prehistórica te espera!

## Características claves
- Exploración de la selva
- Dinosaurios asombrosos
- Desafíos
- Hambientación visual y sonora

## Documento de diseño


## Guía de diseño
En Dinosaur Park, adoptaremos una paleta de colores "Selva Forest" para contextualizar la experiencia en la prehistoria. Con un distintivo estilo pixelart maximalista, buscamos ofrecer una experiencia visual coherente y envolvente que resuene con la temática de aventura.

La interfaz de usuario se mantendrá clásica, intuitiva y fácil de entender, mientras que las animaciones fluidas para personajes y elementos mejorarán la jugabilidad y la inmersión del jugador en este mundo prehistórico.

La diversidad de escenarios proporcionará un viaje emocionante, asegurando que cada nivel ofrezca un diseño único y desafíos renovados para mantener la atención y el interés del jugador.

## Definiciones de diseño del juego

## Victoria (Cómo Ganar)
El jugador alcanza la victoria al superar con éxito el primer nivel y, posteriormente, llega al campamento en el segundo nivel. Esta transición exitosa entre niveles indica el logro final del juego.

## Derrota (Cómo Perder)
La derrota del jugador ocurre al perder todas las vidas otorgadas en el juego, principalmente debido a obstáculos y desafíos presentados en la selva prehistórica.

## Transiciones entre Niveles
Éxito del Nivel: Después de cumplir el objetivo del nivel 1, el juego progresa hacia el nivel 2, donde se presentan desafíos más desafiantes y emocionantes.

## Fracaso del Nivel
En caso de que el jugador pierda todas las vidas, se produce una transición al inicio del nivel 1, reiniciando el juego.

## Enfoque Principal del Juego
El enfoque central del juego es el combate. Los jugadores se sumergen en enfrentamientos estratégicos con dinosaurios y superan desafíos relacionados con el combate para avanzar y alcanzar la victoria.

## Diagrama de flujo del juego

![ ](https://i.postimg.cc/Bbf5Q7xw/diagrama-page-0001.jpg)



## Definicion de jugador

Dirigido a adolescentes en búsqueda de una experiencia emocionante y desafiante, adaptada a su nivel de habilidad y preferencias de juego.
Diseñado con inclusividad en mente, para atraer a jugadores de todos los géneros y garantizar una experiencia equitativa.
Orientado a aquellos que dan sus primeros pasos en el mundo de los videojuegos o tienen habilidades intermedias, el juego ofrece desafíos accesibles mientras sigue siendo entretenido para jugadores más experimentados.
La dificultad se ajusta para ser accesible, asegurando que los jugadores disfruten del juego sin sentirse abrumados, promoviendo así una experiencia divertida y gratificante.
La meta central del juego es llegar al campamento, proporcionando una clara y motivadora dirección para los jugadores mientras exploran la intrigante selva prehistórica.

## Propiedades del jugador

1 **Nombre del jugador**: James.

2 **Propiedades físicas**: Velocidad: James, cuenta con una velocidad ágil para navegar hábilmente por la selva prehistórica, esquivando dinosaurios y superando obstáculos con destreza.

**Salto**: La habilidad de salto de James le permite sortear terrenos accidentados y vencer a sus enemigos prehistóricos con saltos estratégicos y precisos.

3 **Habilidades Especiales**:
**Disparos con un Arma**: James tiene la capacidad de utilizar armas para enfrentarse a los dinosaurios y superar desafíos.

**Ataque con un Cuchillo**: Además, cuenta con habilidades cuerpo a cuerpo, pudiendo desplegar un cuchillo para enfrentarse a enemigos cercanos con rapidez y eficacia.

4 **Personalización**: 
**Aspecto del personaje**: James se presenta con una vestimenta distintiva: una camisa azul, pantalones grises oscuros, botas y un sombrero. Lleva armas a la izquierda de su pantalón y una navaja en el cinturón, destacando su preparación para la aventura.

![ ](https://i.postimg.cc/Jzj5SLZH/Idle-1.png)
## User interface UI

La interfaz del juego en PC para "Dinosaur Park" será diseñada para brindar una experiencia intuitiva y fluida. La barra de salud de James se plantea de manera prominente en la parte superior de la pantalla, permitiendo a los jugadores monitorear su resistencia mientras exploran la selva prehistórica. Los controles, configurados con la tecla W para saltar, A y D para moverse a la izquierda y derecha, S para hagacharse y la barra espaciadora para disparar, se adaptan de manera eficiente a la jugabilidad en PC. Mensajes impactantes de "Game Over" y "Nivel Completado" aparecerán en momentos clave, proporcionando una retroalimentación clara al jugador. Además, un acceso directo al menú principal para garantizar una navegación fácil entre niveles y opciones del juego. La interfaz será simple y efectiva, centrada en mejorar la experiencia de juego en la plataforma de PC.

<img src="https://i.postimg.cc/1XYBGNMW/Menu.png" alt="Logo de Mi Proyecto" width="600"/>
<img src="https://i.postimg.cc/76SrQwjM/Game.png" alt="Logo de Mi Proyecto" width="600"/>
<img src="https://i.postimg.cc/1t1SGWvj/Controles.png" alt="Logo de Mi Proyecto" width="600"/>





## Responsables
- Análisis General: Cabrera Wilson Antonio 
- UX/UI: Cabrera Wilson Antonio
- FrontEnd: Miotto González Lautaro, 
- Backend: Waidatt Samira , Flores Kiru Brian Juan

## Enlaces de interes
[https://www.figma.com/file/E4DjtZd0DoYqhvSLybuhGL/Game](https://www.figma.com/file/E4DjtZd0DoYqhvSLybuhGL/Game---DinosauserPark?type=design&node-id=0-1&mode=design&t=ETiwBzymgyNSVuRo-0)

## Colaboradores
- [@ppedersoli](https://github.com/ppedersoli)

## Autores
- [@Wilson-Cabrera](https://github.com/Wilson-Cabrera)
- Miotto Lautaro Gonzalez
- Flores Juan Kiru
- Waidatt Samira
