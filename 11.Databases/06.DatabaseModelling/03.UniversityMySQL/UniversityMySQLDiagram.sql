-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='TRADITIONAL,ALLOW_INVALID_DATES';

-- -----------------------------------------------------
-- Schema mydb
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema mydb
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `mydb` DEFAULT CHARACTER SET utf8 COLLATE utf8_general_ci ;
USE `mydb` ;

-- -----------------------------------------------------
-- Table `mydb`.`Faculties`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`Faculties` (
  `Id` INT NOT NULL AUTO_INCREMENT COMMENT '',
  `Name` NVARCHAR(50) NOT NULL COMMENT '',
  PRIMARY KEY (`Id`)  COMMENT '',
  UNIQUE INDEX `Id_UNIQUE` (`Id` ASC)  COMMENT '')
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`Students`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`Students` (
  `Id` BIGINT NOT NULL AUTO_INCREMENT COMMENT '',
  `FacultyNumber` BIGINT NOT NULL COMMENT '',
  `Faculties_Id` INT NOT NULL COMMENT '',
  `FirstName` NVARCHAR(50) NOT NULL COMMENT '',
  `LastName` NVARCHAR(50) NULL COMMENT '',
  PRIMARY KEY (`Id`)  COMMENT '',
  UNIQUE INDEX `Id_UNIQUE` (`Id` ASC)  COMMENT '',
  UNIQUE INDEX `FacultyNumber_UNIQUE` (`FacultyNumber` ASC)  COMMENT '',
  INDEX `fk_Students_Faculties_idx` (`Faculties_Id` ASC)  COMMENT '',
  CONSTRAINT `fk_Students_Faculties`
    FOREIGN KEY (`Faculties_Id`)
    REFERENCES `mydb`.`Faculties` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`Departments`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`Departments` (
  `Id` INT NOT NULL AUTO_INCREMENT COMMENT '',
  `Name` NVARCHAR(50) NOT NULL COMMENT '',
  `Faculties_Id` INT NOT NULL COMMENT '',
  PRIMARY KEY (`Id`)  COMMENT '',
  UNIQUE INDEX `Id_UNIQUE` (`Id` ASC)  COMMENT '',
  INDEX `fk_Departments_Faculties1_idx` (`Faculties_Id` ASC)  COMMENT '',
  CONSTRAINT `fk_Departments_Faculties1`
    FOREIGN KEY (`Faculties_Id`)
    REFERENCES `mydb`.`Faculties` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`Courses`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`Courses` (
  `Id` INT NOT NULL AUTO_INCREMENT COMMENT '',
  `Name` NVARCHAR(50) NOT NULL COMMENT '',
  `Departments_Id` INT NOT NULL COMMENT '',
  PRIMARY KEY (`Id`)  COMMENT '',
  UNIQUE INDEX `Id_UNIQUE` (`Id` ASC)  COMMENT '',
  INDEX `fk_Courses_Departments1_idx` (`Departments_Id` ASC)  COMMENT '',
  CONSTRAINT `fk_Courses_Departments1`
    FOREIGN KEY (`Departments_Id`)
    REFERENCES `mydb`.`Departments` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`Professors`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`Professors` (
  `Id` INT NOT NULL AUTO_INCREMENT COMMENT '',
  `FirstName` NVARCHAR(50) NOT NULL COMMENT '',
  `LastName` NVARCHAR(50) NOT NULL COMMENT '',
  `Departments_Id` INT NOT NULL COMMENT '',
  PRIMARY KEY (`Id`)  COMMENT '',
  UNIQUE INDEX `Id_UNIQUE` (`Id` ASC)  COMMENT '',
  INDEX `fk_Professors_Departments1_idx` (`Departments_Id` ASC)  COMMENT '',
  CONSTRAINT `fk_Professors_Departments1`
    FOREIGN KEY (`Departments_Id`)
    REFERENCES `mydb`.`Departments` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`ProfessorsCourses`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`ProfessorsCourses` (
  `Professors_Id` INT NOT NULL COMMENT '',
  `Courses_Id` INT NOT NULL COMMENT '',
  INDEX `fk_ProfessorsCourses_Professors1_idx` (`Professors_Id` ASC)  COMMENT '',
  INDEX `fk_ProfessorsCourses_Courses1_idx` (`Courses_Id` ASC)  COMMENT '',
  CONSTRAINT `fk_ProfessorsCourses_Professors1`
    FOREIGN KEY (`Professors_Id`)
    REFERENCES `mydb`.`Professors` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_ProfessorsCourses_Courses1`
    FOREIGN KEY (`Courses_Id`)
    REFERENCES `mydb`.`Courses` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`StudentsCourses`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`StudentsCourses` (
  `Students_Id` BIGINT NOT NULL COMMENT '',
  `Courses_Id` INT NOT NULL COMMENT '',
  INDEX `fk_StudentsCourses_Students1_idx` (`Students_Id` ASC)  COMMENT '',
  INDEX `fk_StudentsCourses_Courses1_idx` (`Courses_Id` ASC)  COMMENT '',
  CONSTRAINT `fk_StudentsCourses_Students1`
    FOREIGN KEY (`Students_Id`)
    REFERENCES `mydb`.`Students` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_StudentsCourses_Courses1`
    FOREIGN KEY (`Courses_Id`)
    REFERENCES `mydb`.`Courses` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`Titles`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`Titles` (
  `Id` INT NOT NULL AUTO_INCREMENT COMMENT '',
  `Name` NVARCHAR(50) NOT NULL COMMENT '',
  PRIMARY KEY (`Id`)  COMMENT '',
  UNIQUE INDEX `Id_UNIQUE` (`Id` ASC)  COMMENT '')
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`TitlesProfessors`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`TitlesProfessors` (
  `Professors_Id` INT NOT NULL COMMENT '',
  `Titles_Id` INT NOT NULL COMMENT '',
  INDEX `fk_TitlesProfessors_Professors1_idx` (`Professors_Id` ASC)  COMMENT '',
  INDEX `fk_TitlesProfessors_Titles1_idx` (`Titles_Id` ASC)  COMMENT '',
  CONSTRAINT `fk_TitlesProfessors_Professors1`
    FOREIGN KEY (`Professors_Id`)
    REFERENCES `mydb`.`Professors` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_TitlesProfessors_Titles1`
    FOREIGN KEY (`Titles_Id`)
    REFERENCES `mydb`.`Titles` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
