//This program was created to illustrate the chapter: 
// An Updated and Simplified Version of a Low-Cost Arduino-Visual Basic Interface for Operant Research
// by Rogelio Escobar, Rodrigo Benavides and Brissa Gutiérrez
// National Autonomous University of Mexico
// in Digital Technologies in Behavioral Science edited by Donald Hantula, Darlene Crone-Todd, and T.V. Joe Lang



//Variable declaration
//The pins declared in this section match an Arduino Mega 360 board. To use with an Arduino UNO board use pins from 2 to 12
// for example byte Sonalert = 12;

byte Houselight = 4;
byte Sonalert = 25;
byte Response1 = 8;
byte Response2= 9;
byte Light_1= 3;
byte Water = 53;
//byte bulb28v = 8; //This line is needed only to exemplify the control of 28V devices in commercial chambers. 
byte Step_Right = 37;
byte Dir_Right =31;
int StepCount = 0;

void setup() {
  //The setup code here, enables serial communication, declares devices as inputs or outputs and set the initial values of devices. 
Serial.begin(9600);
 pinMode(Houselight, OUTPUT);
 pinMode(Light_1, OUTPUT);
 //pinMode(bulb28v, OUTPUT); //This line is needed only to exemplify the control of 28V devices in commercial chambers. 
 pinMode(Water, OUTPUT);
 pinMode(Sonalert, OUTPUT);
 pinMode(Step_Right, OUTPUT);
 pinMode(Dir_Right, OUTPUT);
 pinMode(Response1,INPUT_PULLUP);
 pinMode(Response2,INPUT_PULLUP);
 
 digitalWrite (Light_1,LOW);
 digitalWrite (Houselight,LOW);
 digitalWrite (Water,LOW);
 digitalWrite (Sonalert,LOW); 
}


void loop() {
  // This is the main code that is run repeatedly.
  // These instructions wait for letters sent to the serial port to execute an instructions (see below)
 if (Serial.available()>0){
   char Event=Serial.read();
    //Experimental events are coded as cases in terms of characters introduced in the serial port. The letter expected in each case executes the lines
    //with digitalWrite that changes the state of output devices
    switch (Event){
    case 'A': //if letter A is found in the serial port
    digitalWrite (Houselight, HIGH); // turn on the Houselight attached to pin 4 
    break; 
        
    case 'B':
    digitalWrite (Light_1, HIGH);
    break;
      
    case 'b':
    digitalWrite (Light_1, LOW);
    break;    
      
    case 'C':   
    digitalWrite (Light_1, HIGH);
    delay (500); 
    digitalWrite (Light_1, LOW);
    delay(500);       
    break;
         
    case 'R': //This code is required for 3D printed pellet dispensers equipped with NEMA 17 stepper motors
    for (StepCount = 0; StepCount < 80; StepCount++){
    digitalWrite(Step_Right,HIGH);
    delay(5);
    digitalWrite(Step_Right,LOW);
    delay(5);    
    }
    break;
         
    case 'T':
    digitalWrite (Sonalert, HIGH);
    delay(500); 
    digitalWrite(Sonalert, LOW);
    delay(500);
    break;
     
    case 'Z':
    digitalWrite (Sonalert, HIGH);
    break;
    case 'z':
    digitalWrite(Sonalert, LOW);
    break;
        
    case 'Q':
    digitalWrite (Water, HIGH);
    delay(500); 
    digitalWrite (Water, LOW);
    break;
     
        }
}
//These lines read the state of inputs. The state is written in the Serial port. The state is read in the Visual Basic program described in the chapter.
 Serial.println(String(digitalRead(Response1))+","+String(digitalRead(Response2)));
  delay (4);
}
