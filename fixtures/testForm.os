#Использовать gui

Перем ТекстовоеПоле1;
Перем Форма;

Процедура ПриНажатииНаКнопку() Экспорт
	ТекстовоеПоле1.Значение = "НовоеЗначение";
КонецПроцедуры

Процедура ПриСозданииОбъекта()

	УправляемыйИнтерфейс = Новый УправляемыйИнтерфейс;
	Форма = УправляемыйИнтерфейс.СоздатьФорму();

	Элементы = Форма.Элементы;
	ВидыПоляФормы = Форма.ВидПоляФормы;
	// ПоложениеЗаголовка = Форма.ПоложениеЗаголовка;
	// ВидГруппыФормы = Форма.ВидГруппыФормы;	

	ТекстовоеПоле1 = Элементы.Добавить("ТекстовоеПоле1", "ПолеФормы", Неопределено);
	ТекстовоеПоле1.Заголовок = "Текстовое поле 1:";
	ТекстовоеПоле1.Вид = ВидыПоляФормы.ПолеВвода;
	ТекстовоеПоле1.Значение = "Какой-то текст ...";
	
	Кнопка1 = Элементы.Добавить("Кнопка1", "КнопкаФормы", Неопределено);
	Кнопка1.Заголовок = "Нажми меня";
	// Кнопка1.КнопкаНажатие(ЭтотОбъект,"ПриНажатииНаКнопку");
	Кнопка1.УстановитьДействие(ЭтотОбъект, "Нажатие", "ПриНажатииНаКнопку");

	Форма.Показать();

КонецПроцедуры
