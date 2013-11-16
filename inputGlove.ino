int testInputPin = 9;
int testOutputPin = 8;
int testFeedbackPin = 13;

void setup()
{
  pinMode(testInputPin, INPUT_PULLUP);
  pinMode(testOutputPin, OUTPUT);
  pinMode(testFeedbackPin, OUTPUT);
  digitalWrite(testOutputPin, HIGH);
  Serial.begin(9600);
}

void loop()
{
  if(digitalRead(testInputPin) == LOW)
  {
    digitalWrite(testFeedbackPin, HIGH);
  }
   else if(digitalRead(testInputPin) == HIGH)
  {
    digitalWrite(testFeedbackPin, LOW);
  }
  Serial.write(analogRead(testInputPin));
}
