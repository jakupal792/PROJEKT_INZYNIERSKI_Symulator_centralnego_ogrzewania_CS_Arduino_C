UWAGA! Kod Arduino (utworzony w języku C) znajduje się w pliku "Symulator_aplikacja_arduino.ino"!

Niniejsza aplikacja została stworzona jako projekt inżynierski na kierunku Informatyka Przemysłowa.
Celem pracy było przygotowanie desktopowej, graficznej aplikacji symulującej działanie układu centralnego ogrzewania, 
wyposażonego w indywidualne, konwencjonalne źródło ciepła, spalające węgiel kamienny, umożliwiającej
monitorowanie stanu układu oraz sterowanie nim, poprzez zadawanie temperatury którą układ ma osiągnąć i podtrzymywać 
oraz generowanie sygnałów informujących o temperaturach panujących w układzie. W celu wykonania symulacji aplikacja
współpracuje z platformą Arduino. Przeznaczeniem aplikacji jest obrazowanie działania układów grzewczych, 
umożliwianie zrozumienia działania używanych przez nie mechanizmów oraz rządzących nimi praw fizycznych, a także wyznaczanie
charakterystyk układów centralnego ogrzewania w celu wspomagania prac projektowych nad nimi. Zadaniem aplikacji jest 
symulowanie przeznaczonego dla domu jednorodzinnego lub innego wolno stojącego budynku układu centralnego ogrzewania,
zasilanego kotłem spalającym węgiel kamienny, wyposażonym w podajnik opału z mechanizmem ślimakowym, 
z wodą jako nośnikiem ciepła oraz czujnikami temperatury, przesyłającymi informacje o panujących w układzie temperaturach - dwoma
umieszczonymi w ogrzewanych pomieszczeniach, mierzącymi temperaturę powietrza w nich i jednym wbudowanym w kocioł,
mierzącym temperaturę wody przepływającej przez niego – oraz sygnalizatorami awarii. Praca aplikacji polega na monitorowaniu
symulowanego układu, poprzez pobieranie i wyświetlanie danych o jego stanie (temperaturach, procesach zachodzących w kotle 
i ewentualnych awariach) oraz sterowaniu nim (doprowadzaniu temperatury w pokojach do wartości oczekiwanej
przez użytkownika, poprzez uruchamianie i zatrzymywanie podajnika opału, wyliczanie masy opału koniecznej do zwiększenia 
temperatury oraz wyznaczanie czasu poszczególnych cyklów pracy). 

