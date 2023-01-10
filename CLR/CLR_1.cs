// ключевое слово "is" для сравнения объектов
if (object is Employee)
{
    Employee employee = (Employee) object;
}
//is при сравнении возвращает bool

//ключевое слово "as" для сравнения объектов
Employee e = object as Employee;
if(e != null)
{

}
//as возвращает объект или null

//Различия между is и as

//IS:
//Проверка типа производится дважды.
//Проверяется совместимость object и Employee.(Имеется в виду наследование?)
//Проверяются ссылки object на Employee.

//AS:
//Проверка производится только один раз.
//Производиться верификация объекта.