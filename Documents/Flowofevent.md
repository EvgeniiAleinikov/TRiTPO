# Поток событий
### 1 Вход через страницу входа
**Основной поток событий:**
1. Вариант использования начинается, при входе пользователя в приложение в браузере.
2. Неавторизированному пользователю отображается веб-страница с предложением выбрать одну из соть сетей для входа.
3. Неавторизированному пользователю предлогаеться подтвердить желание войти.
4. Пользователь перенаправляеться на страницу со списком комнат.
5. Вариант использования завершается.
### 2 Выбор комнаты
**Основной поток событий:**
1. Вариант использования начинается, при  перенаправлении после авторизации.
2. Авторизованному пользователю выводиться страница со списком комнат.
3. Авторизированный пользователь выбирает одну из предложенных комнат и кликает по ней.
4. Пользователь перенаправляеться на страницу выбранной комнаты.
5. Вариант использования завершается.
### 3 Просмотр комнаты
**Основной поток событий:**
1. Вариант использования начинается, после выбора комнаты пользователем комнат.
2. Авторизированный пользователь нажимает на кнопку «Войти» возле названия комнаты в отображаемом списке.
3. Авторизированному пользователю отображается веб-страница с содержимым текущей комнаты.
4. Вариант использования завершается.
### 4 Создание комнаты
**Основной поток событий:**
1. Вариант использования начинается, когда пользователь создает новую комнату.
2. Авторизированный пользователь вводит название новой комнаты в форму.
3. Всем авторизированным пользователям отображается новая комната со стандартным названием.
4. Пользователь перенаправляеться на созданную комнату.
4. Вариант использования завершается.
### 5 Ввод текста
**Основной поток событий:**
1. Вариант использования начинается, когда авторизированный пользователь принимает решение добавить на канвас текст.
2. Авторизированный пользователь нажимает на кнопку режима добавления текста.
3. Авторизированный пользователь нажимает на холст мышкой.
4. Авторизированный пользователь вводит необхадимый текст.
5. Авторизированный пользователь заканчивает ввод текста кликом вне текста.
6. У всех авторизированных пользователей отображаеться введенный текст.
7. Вариант использования завершается.
### 6 Рисование
**Основной поток событий:**
1. Вариант использования начинается, когда авторизированный пользователь принимает решение нарисовать линию.
2. Авторизированный пользователь нажимает на канвас комнаты и с нажатой кнопкой проводит необходимую линию.
3. Остальные авторизированные пользователи, находящиеся в текущей комнате, получают изменения текущей 
   комнаты.
4. Вариант использования завершается.