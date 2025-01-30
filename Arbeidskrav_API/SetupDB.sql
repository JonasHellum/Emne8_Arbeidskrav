DROP DATABASE IF EXISTS Emne8_Arbeidskrav;
CREATE DATABASE Emne8_Arbeidskrav;
use Emne8_Arbeidskrav;

CREATE USER IF NOT EXISTS 'ga-app'@'localhost' IDENTIFIED BY 'ga-5ecret-%';
CREATE USER IF NOT EXISTS 'ga-app'@'%' IDENTIFIED BY 'ga-5ecret-%';

GRANT ALL privileges ON Emne8_Arbeidskrav.* TO 'ga-app'@'%';
GRANT ALL privileges ON Emne8_Arbeidskrav.* TO 'ga-app'@'localhost';