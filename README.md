# Emne 8 arbeidskrav

## Developer Details
Jonas Lærke Hellum<br/>
https://github.com/JonasHellum

## License
This project is licensed under the MIT License. For more details, please refer to the LICENSE.txt file.

## Oppsett
Inne i docker-compose.yml filen så er det satt opp for å opprette web, api og database containere fra images som er lagret på docker.com. <br/>
Web er via nginx som har tilgang til apiet og databasen, portene er lukket så de har bare kommunikasjon via docker-containerane i samme nettverk. <br/>
Det er bare 2 forskjellige kall man kan gjøre med denne, det er en GET og en POST. <br/>

## Instruksjon
Gå inn i folderen som har docker-compose.yml filen og kjør "docker-compose up -d" så vil den hente alle imagesa fra docker.com og sette sette opp riktige containere. <br/>
For å kjøre GET kallet så må man bruke "http://localhost:81/api/v1/books/GetBooks", da vil man få ut alle bøkene som er lagret i databasen.
For å kjøre POST så må man bruke "http://localhost:81/api/v1/books/AddBook" med fks. postman. Oppsettet til denne er: <br/>
{ <br/>
  "author": "string", <br/>
  "title": "string", <br/>
  "published": "2025-01-29" <br/>
} <br/>
Da vil den informasjonen bli lagret til databasen.

APIet er bare et veldig basic api som ble laget for docker-compose, det er ikke feilhåndteringer, authentication eller noe. <br/>
