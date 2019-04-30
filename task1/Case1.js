var budjet = prompt("Ваш бюджет на месяц?", "");
var date = prompt("Введите дату в формате YYYY-MM-DD", "");
var rashody = prompt("Введите обязательную статью расходов в этом месяце", "");
var solkoRashody = prompt("Во сколько обойдется?", "");

var appData = {
    budjet1: budjet,
    timeData: date,
    expenses: {
        rashody1: rashody,
        solkoRashody1: solkoRashody 
        },
    optionalExpenses: {},
    income: [],
    savings: false,    
};

alert("Ваш бюджет на 1 день составляет: " + appData.budjet1 / 30);