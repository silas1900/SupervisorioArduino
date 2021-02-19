#include <Thermistor.h>

#define led 7
#define led1 6
#define led2 5
#define led3 4
#define ledPWM 9

unsigned int pot = 0;
Thermistor temp(A0); // termistor ligado A0 da placa
void sensor1();
void sensor2();


void setup() {
  // put your setup code here, to run once:
 Serial.begin(9600);
 pinMode(led,OUTPUT);
 pinMode(led1,OUTPUT);
 pinMode(led2,OUTPUT);
 pinMode(led3,OUTPUT);
 pinMode(ledPWM,OUTPUT);
 
 pinMode(A1,INPUT);

 analogWrite(ledPWM,0);
 
 digitalWrite(led,LOW);
 digitalWrite(led1,LOW);
 digitalWrite(led2,LOW);
 digitalWrite(led3,LOW);
}

void loop() {

  if (Serial.available()>0){
    char caractere = Serial.read(); // Armazena caractere lido
    //Serial.println(caractere);
    
    
    if(caractere  == 'P'){
       digitalWrite(led,HIGH);
       delay(100);
       digitalWrite(led,LOW);
       Serial.print("[OK!]");
    }else if(caractere  == 'S'){
       digitalWrite(led,LOW);
       digitalWrite(led1,LOW);
       digitalWrite(led2,LOW);
       digitalWrite(led3,LOW);
       analogWrite(ledPWM,0 );
    }
    else if(caractere  == '1'){
       digitalWrite(led1,HIGH);
       Serial.print("[OK!]");
    }else if(caractere == '2'){
      digitalWrite(led1,LOW);
      Serial.print("[OK!]");
    }else if(caractere == '3'){
      digitalWrite(led2,HIGH);
      Serial.print("[OK!]");
    }else if(caractere == '4'){
      digitalWrite(led2,LOW);
      Serial.print("[OK!]");
    }else if(caractere == '5'){
      digitalWrite(led3,HIGH);
      Serial.print("[OK!]");
    }else if(caractere == '6'){
      digitalWrite(led3,LOW);
      Serial.print("[OK!]");
    }else if (caractere == '7'){
       analogWrite(ledPWM,0 );//0
       Serial.print("[OK!]");
    }else if (caractere == '8'){
      analogWrite(ledPWM,50 );//64
       Serial.print("[OK!]");
    }else if (caractere == '9'){
       analogWrite(ledPWM,100 );//127
        Serial.print("[OK!]");
    }else if (caractere == 'A'){
      analogWrite(ledPWM,150 );//191
       Serial.print("[OK!]");
    }else if (caractere == 'B'){
       analogWrite(ledPWM,200 );//255
        Serial.print("[OK!]");
    }else if (caractere == 'C'){
      analogWrite(ledPWM,255 );//255
       Serial.print("[OK!]");
    }
  }

  sensor1();
  Serial.print("[OK!]");
  delay(500);
  sensor2();
  Serial.print("[OK!]");
  
     
}
void sensor1(){

 
     unsigned int temperatura = temp.getTemp();
      delay(5);
      Serial.print("[A1");
      Serial.print((temperatura/1000));
      Serial.print((temperatura/100)%10);
      Serial.print((temperatura/10)%10);
      Serial.print((temperatura%10));
      Serial.print(']');
           
}
void sensor2(){
  
    pot = analogRead(A1);
    delay(5);
    Serial.print("[A2");
    Serial.print((pot/1000));
    Serial.print((pot/100)%10);
    Serial.print((pot/10)%10);
    Serial.print((pot%10));
    Serial.print(']');
    
   
}
