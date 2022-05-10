-Endy Infante
-1096157

# Plan de pruebas

## Casos de prueba

### POSITIVE REQUIRED NUMBER OF DIGITS

Test Name: Positive Scenario for the number of digits required.


- Objective Test that an SSN is entered with the required digit separation by -: It should have 9 digits.
It should be divided into 3 parts by hyphen (-). The first part should have 3 digits and should not be 000, 666, or
between 900 and 999. The second part should have 2 digits and it should be from 01 to 99. The third part should
have 4 digits and it should be from 0001 to 9999.


- The user will enter the SSD and press enter which will give way to verification.


- In the event that the number has the required digits, it will continue with the verification.


-SSD: 123-45-7896


Expected Results: Message "Your SSD is OK."


###NEGATIVE NUMBER OF DIGITS REQUIRED

Test Name: Negative scenario for the number of digits required.


- Objective Test that an SSN is entered with the required digit separation by -: It should have 9 digits.
It should be divided into 3 parts by hyphen (-). The first part should have 3 digits and should not be 000, 666, or
between 900 and 999. The second part should have 2 digits and it should be from 01 to 99. The third part should
have 4 digits and it should be from 0001 to 9999.


- The user will enter the SSD and press enter which will give way to verification.


- In the event that the number has the required digits, it will continue with the verification.


-SSD: 123-455-7896


- Expected Results: Message "Your SSD is incorrect. It must have 9 digits."

### POSITIVE NUMBER SEPARATION OF DIGITS BY -

Test Name: Positive scenario for the separation of digits by -.

- Objective Test that an SSN is entered with the required digit separation by -: It should have 9 digits.
It should be divided into 3 parts by hyphen (-). The first part should have 3 digits and should not be 000, 666, or
between 900 and 999. The second part should have 2 digits and it should be from 01 to 99. The third part should
have 4 digits and it should be from 0001 to 9999.


- The user will enter the SSD and press enter which will give way to verification.


- In the event that the number has the digit separation by (-) it will continue with the verification.


- In case you do not have the correct separation of digits, the software will send you a message with the error.


- SSD: 123-45-7896


- Expected Results: Message "Your SSD is OK."


###NEGATIVE NUMBER SEPARATION OF DIGITS BY -

Test Name: Negative scenario for the separation of digits by -.


- Objective Test that an SSN is entered with the required digit separation by -: It should have 9 digits.
It should be divided into 3 parts by hyphen (-). The first part should have 3 digits and should not be 000, 666, or
between 900 and 999. The second part should have 2 digits and it should be from 01 to 99. The third part should
have 4 digits and it should be from 0001 to 9999.


- The user will enter the SSD and press enter which will give way to verification.


- In the event that the number has the digit separation by (-) it will continue with the verification.


- In case you do not have the correct separation of digits, the software will send you a message with the error.


- SSD: 123-445-896


- Expected Results: Message "Your SSD is incorrect. It must be divided into 3 parts by hyphen (-)."


###POSITIVE CHECK OF FIRST GROUP OF NUMBERS

Test Name: Positive scenario for the verification of the first group of numbers.


- Objective Test that an SSN is entered with the required digit separation by -: It should have 9 digits.
It should be divided into 3 parts by hyphen (-). The first part should have 3 digits and should not be 000, 666,
or between 900 and 999. The second part should have 2 digits and it should be from 01 to 99. The third part should
have 4 digits and it should be from 0001 to 9999.


- The user will enter the SSD and press enter which will give way to verification.


- In the event that the number has the digit separation by (-) it will continue with the verification.


- In case you do not have the correct separation of digits, the software will send you a message with the error.


- SSD: 123-45-4896


- Expected Results: Message "Your SSD is OK."


###NEGATIVE CHECK OF FIRST GROUP OF NUMBERS

Test Name: Negative scenario for the verification of the first group of numbers.


- Objective Test that an SSN is entered with the required digit separation by -: It should have 9 digits.
It should be divided into 3 parts by hyphen (-). The first part should have 3 digits and should not be 000, 666,
or between 900 and 999. The second part should have 2 digits and it should be from 01 to 99. The third part should
have 4 digits and it should be from 0001 to 9999.


- The user will enter the SSD and press enter which will give way to verification.


- In the event that the number has the digit separation by (-) it will continue with the verification.


- In case you do not have the correct separation of digits, the software will send you a message with the error.


- SSD: 1234-45-896


- Expected Results: Message "Your SSD is incorrect. The first part should have 3 digits and should not be
000, 666, or between 900 and 999."


###NEGATIVE SECOND GROUP OF NUMBERS CHECK

Test Name: Negative scenario for the verification of the second group of numbers.


- Objective Test that an SSN is entered with the required digit separation by -: It should have 9 digits.
It should be divided into 3 parts by hyphen (-). The first part should have 3 digits and should not be 000, 666, or
between 900 and 999. The second part should have 2 digits and it should be from 01 to 99. The third part should
have 4 digits and it should be from 0001 to 9999.


- The user will enter the SSD and press enter which will give way to verification.


- In the event that the number has the digit separation by (-) it will continue with the verification.


- In case you do not have the correct separation of digits, the software will send you a message with the error.


- SSD: 1234-45-896


- Expected Results: Message "Your SSD is incorrect. The second part should have 2 digits and it should be from
01 to 99."


### POSITIVE CHECK OF SECOND GROUP OF NUMBERS

Test Name: Positive scenario for the verification of the second group of numbers.


- Objective Test that an SSN is entered with the required digit separation by -: It should have 9 digits.
It should be divided into 3 parts by hyphen (-). The first part should have 3 digits and should not be 000, 666, or
between 900 and 999. The second part should have 2 digits and it should be from 01 to 99. The third part should
have 4 digits and it should be from 0001 to 9999.


- The user will enter the SSD and press enter which will give way to verification.


- In the event that the number has the digit separation by (-) it will continue with the verification.


- In case you do not have the correct separation of digits, the software will send you a message with the error.


- SSD: 123-45-7896


- Expected Results: Message "Your SSD is OK."



###POSITIVE CHECK OF THIRD GROUP OF NUMBERS

Test Name: Positive scenario for the verification of the third group of numbers.


- Objective Test that an SSN is entered with the required digit separation by -: It should have 9 digits.
It should be divided into 3 parts by hyphen (-). The first part should have 3 digits and should not be 000, 666, or
between 900 and 999. The second part should have 2 digits and it should be from 01 to 99. The third part should
have 4 digits and it should be from 0001 to 9999.


- The user will enter the SSD and press enter which will give way to verification.


- In the event that the number has the digit separation by (-) it will continue with the verification.


- In case you do not have the correct separation of digits, the software will send you a message with the error.


- SSD: 123-45-7896


- Expected Results: Message "Your SSD is OK."



###NEGATIVE CHECK OF THE THIRD GROUP OF NUMBERS

Test Name: Negative scenario for the verification of the third group of numbers.


- Objective Test that an SSN is entered with the required digit separation by -: It should have 9 digits.
