# Первый файл по контролю версий
## Выделение текста

Для выделение текста курсивом добавьте по его концам: 

#### ``` *Курсив* ```</p>

 *Курсив.*

Для выделение текста полужирным добавьте по его концам:: 
#### ``` **Полужирный** ``` </p>
 **Полужирный.**

## Списки
Для добавления ненумерованного списка добавьте в начало: 
```
* Элемент
```
* Элемент 1
* Элемент 2
* Элемент 3

Для добавления ненумерованного списка добавьте в начало цифру: 
```
1. Первый элемент нумерованного списка.
2. Второй элемент нумерованного списка.
```
1. Первый элемент нумерованного списка.
2. Второй элемент нумерованного списка.

## Цитирование в языке Markdown:
Для цитирования нужно добавить в начало знак:
#### ``` >Первый уровень >>Второй уровень ``` </p>

>Первый уровень
>>Второй уровень

## WEB ссылки
Для выделения ссылки за вводим название ссылки и заключаем его в кв. скобки, далее в кр. скобках указываем ссылку и  используя ковычки вставляем всплывающию подсказку:

#### ``` Текст [пример ссылки](http.example.com "Всплывающая подсказка") ```</p>

Текст [пример ссылки](http.example.com "Всплывающая подсказка")


![Изображение](git.jpg "Гит ты маму маф")

# Начало работы с git

&nbsp;  Для начала работы с git необходимо его скачать, сделать это можно по данной [ссылке](<https://git-scm.com/downloads> "Последняя версия git. Официальный сайт"). <br>
&nbsp;  Затем в [MS Visual code](<https://code.visualstudio.com/> "Сайт для загрузки") открываем или создаем папку в которой и будем работать (Предварительно загрузив его и [DotNet](<https://dotnet.microsoft.com/en-us/download> "Сайт для загрузки")). Здесь мы можем создать различные файлы и папки. Теперь нужно инициализировать папку для отслеживания git-ом, для этого перейдя в нужную папку пишем команду в ***терминал***: <br> 
#### ``` git init ``` </p>
&nbsp; Теперь папка стала _репозиторием_ (хранилищем), за которым будет следить git.
Удалить репозиторий можно как в ручную, удалив скрытую папку .git, так и с помощью команды:
#### ``` rm -r .git ``` </p>
&nbsp;  Перед началом работы с git вам необходимо указать свои данные (рассказать о пользователе), так будет видно кем был изменен код. Для этого пропишем команды:
#### ``` git config --global user.name <Имя пользователя> ``` </p>
#### ``` git config --global user.email <Ваша почта> ``` </p>

## Сохранения

&nbsp;  Вся суть git кроется как раз в ***Сохранениях***. После каждого изменения любого файла в папке отслеживаемой git необходимо сначала добавить папку в git, а затем сохранить изменения в самом git. Чтобы отслеживать текущее состояние папок и файлов, за которыми закреплен git нужно ввести команду:
#### ``` git status ``` </p>
&nbsp;  Красным будут выделены те файлы и папки, за которыми не закреплен git, а зелеными, те, что вы недавно включили в 'слежку' git-ом.
Для закрепления файла или папки к git, вводим команду:
#### ``` git add <Путь к папке> ``` </p>
&nbsp;  А для создания сохранения (снимка), команду:
#### ``` git commit -m "Название сохранения" ``` </p>
&nbsp;  Также в git можно посмотреть историю всех сохранений, для этого нужно ввести:
#### ``` git log ``` </p>
&nbsp;  Или для более короткой версии:
#### ``` git log --oneline ``` </p>
&nbsp;  Здесь будут показаны все сохранения (версии) кода, и их уникальный идентификатор, по которому вы с легкостью можете 'откатить' версию назад. Для этого вводим команду:
#### ``` git checkout <номер версии>  ``` </p>
&nbsp;  Вводить весь идентификатор не обязательно, **достаточно ввести первые 4 символа**. <br>
&nbsp;  Для просмотра изменений до сохранения используется команда:
#### ``` git diff ``` </p>

## Ветки

&nbsp; Ветка в Git — это набор коммитов, расположенных в хронологическом порядке. У каждой ветки есть свое название. Основная ветка называется master, она появляется при инициализации репозитория и считается главной веткой проекта. 
Другим веткам вы даете имена самостоятельно. Дополнительные ветки могут использоваться как черновики (сначала выполнить работу в них, а затем переносить изменения в главную ветку) или же для совместной работы (для распределения обязанностей путём разбивания кода на этапы). <br>

&nbsp; Чтобы создать ветку необходимо ввести следующую команду:
#### ``` git branch <Название ветки> ``` </p>

&nbsp; Чтобы перейти в нужную ветку используется команда:
#### ``` git checkout <Название ветки> ``` </p>
&nbsp; Также вы можете просмотреть все имеющиееся ветки командой:
#### ``` git branch ``` </p>
&nbsp; Звездочкой будет отмечена текущая ветка. Более того вы можете видеть в какой вы ветке выполнив команду ```git status```. <br>

&nbsp; Еще, командой:
#### ``` git log --graph ``` </p>
&nbsp; Можно увидеть "Дерево" коммитов. <br>
&nbsp; Для того, чтобы слить побочную ветку с главной нужно, находясь в главной ветке, написать команду:
#### ``` git merge <Название ветки> ``` </p>


## Github и работа с удаленными репозиториями

&nbsp; Самое главная фишка git - это использование удаленных репозиториев и работа с ними. 

&nbsp; Удаленный репозиторий Git — это версии проекта, сохранённые на удалённом сервере. Доступ к репозиторию может осуществляться по интернету или по локальной сети.

&nbsp; Для работы с удаленными репозиториями рекомендуем использовать GitHUB. GitHUB — это удаленный хостинг репозиториев git.

&nbsp; С его помощью вы можете свободно загружать себе чужие наработки или делиться своими. Для того, чтобы скопировать код не нужно даже регистрироваться на хостинге, нужно лишь скопировать ссылку на код в GitHUB и ввсети в терминале, в своем локальном репозитории команду:
#### ``` git clone <URL репозитория> ``` </p>
&nbsp; Готово теперь у вас есть полная копия файлов из репозитория на GitHUB. (Не забудьте перейти в нужную папку командой ```cd```).

&nbsp; Для того, чтобы загрузить ваши файлы в удаленный репозиторий необходимо его сначала создать, а для этого придется пройти регистрацию.
&nbsp; После прохождения регистрации нажимаем на кнопку создания репозитория, где нам будет предложено 2 варианта.
1. Создать новый локальный репозиторий с нуля на своем компьютере и отправить его.
2. Отправить уже существующий локальный репозиторий.

&nbsp; Далее нужно просто следовать командам, которые так любезно предоставляет GitHUB.

&nbsp; Обновив страницу вы увидите ваш новый репозиторий на GitHUB.

