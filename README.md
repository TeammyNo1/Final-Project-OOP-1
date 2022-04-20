1.ความเป็นมาของโปรแกรม
  ```
 อยากสร้างโปรแกรมเกี่ยวกับการจอดรถ เพราะมีปัญหาเกี่ยวการ หาที่จอดรถยากและลืมที่จอดรถบ่อย 
  ```
2.วัตถุประสงค์ของโปรแกรม
 ```
 1.เพื่อให้ผู็คนที่จะเข้ามาจอดรถได้เลือกที่จอดได้ง่ายขึ้นเเละไม่มีรถคันอื่นมาแย่งที่จอดกัน
 2.สามารถมีอีเมลส่งไปบอกว่าที่จอดของคุณอยู๋เลขอะไร/อยู่ที่ตรงไหน
 3.สามารถคำนวณตังค์ เเละมีส่วนลดให้ง่ายๆ เพื่อบ้างคนไม่ถนัด คณิต 
 ```
3.โครงสร้างของโปรแกรม (Class diagram) ของโปรแกรม ใช้ Mermaid ในการเขียน ตัวอย่าง การเขียน Classdiagram ใน Markdown
 Class Diagram
 ```mermaid
classDiagram
  direction LR
  class form1{
  -cheakin():void
  -cheaout():void
  -Save():void
  -Clear():void
}
  class Pay{
  -discountcode():void
  -pay():void
  -back():void
  }
  class codepay{
  -couponCode:string
  -minimumPice:double
  +creat(double min):void
  +getCoupon():void
  }
  class Buy{
  -totalPice:double
  +Bill(pay double,getmoney Double):void
  +payBill():double
   }
   Pay -- codepay
   Pay -- Buy
   
  ```
 4.ชื่อของผู้พัฒนาโปรแกรม
  ```
 นาย ธนบดี สัวสดี 643450325-4
  ```
