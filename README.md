# UZNAMVSE-INFO_Cards
Theme: «Игровая программа “Карты”» 
<h2>Индивидуальное проектирование:</h2>
<li>Разработка Windows-приложений на языке C#</li>

<h2>Project Description</h2>
У пользователя на отдельной форме запрашивается имя, которое далее используется для обозначения карт игрока (см. рисунок) и определения имени  победителя. 
По щелчку на кнопке Раздать игроку Трус верхнее поле заполняется изображениями 6-ти карт и становится доступной кнопка Себе. 
По щелчку на кнопке Себе карты раздаются пользователю. После раздачи карт становятся доступными функции Разложить и Определить победителя. 
По кнопке Разложить карты сортируются и выкладываются для каждого игрока по возрастанию. 
По кнопке Определить победителя суммируются очки, присущие каждой карте (шестерка=1, семерка=2, восьмерка=3 и т.д.), и определяется победитель в данной игре. 
Кнопка Сначала начинает игру заново.

<h2>"C" grade option</h2>
Реализация основного хода игры:  
<li>запрос имени пользователя</li>
<li>сдача в случайном порядке карт игрокам (возможны повторы)</li>
<li>определение победителя (возможны три варианта: ничья, победитель Трус, победитель пользователь).</li>

Организация аварийного выхода/начала игры (кнопка Сначала). 

<h2>"B" grade option</h2>
Реализация сдачи карт без повторов. 

<h2>"A" grade option</h2>
Реализация работы кнопки Разложить. 

<h2>"A+" grade option</h2>
<li>Разложить карты по мастям и по возрастанию внутри каждой масти</li>
<li>Начисление очков ведется следующим образом: очки на картах с числами соответствуют достоинству карты, на картах с картинками: валет=2, дама=3, король=3, туз=11.</li>
<li>Ведется накопление очков по результатам нескольких игр.</li>
<li>У игроков имеется возможность поменять указанную карту на другую из колоды.</li>
