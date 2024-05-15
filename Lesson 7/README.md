Experiment - Parse Operations
Create an advanced calculator. This calculator will take the mathematical expression into the relevant action 
field (TextBox). Then, when the "AC" button is pressed, the result will be written in the same TextBox area. The 
mathematical expression to be written may include simple mathematical operations or more than one 
mathematical expression. In such a case, pay attention to parentheses and operation precedence. In 
mathematical operations, the expression in parentheses is taken as a whole and attention is paid to transaction 
priority.
Processing priorities are as follows:
1- Parentheses
2- Exponents and roots
3- Multiplication-division
4- Addition-subtraction
5- In multiple operations, the operation occurs from left to right.
The mathematical expression entered in the TextBox field must be taken, parsed operations must be performed, 
and the operation result must be calculated correctly.
After completing the transactions, the transactions made until the form is closed should be listed in the "History" 
field (ListBox can be used).
Some transaction examples:
(25 - 5 + 34) - (26 × 3) = -24
Checkpoints;
1. Create your calculator design. You will need lots of buttons.
2. When the button is clicked, define the relevant function of the clicked button (adding numbers to the TextBox 
or performing an operation)
3. Take the input in the TextBox as a whole and perform parsing operations. (Expression Parser)
4. Calculate sin, cos, tan, ln, log, pi, e, square, exponansial, %, addition, subtraction, multiplication, division (All 
operations in the image) (Ignoring the "Inv" operation)

