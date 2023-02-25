from flask import Flask, render_template
from random import randint as rd
from loginForm import Lf
from authForm import Auth

app = Flask(__name__)
app.config['SECRET_KEY'] = '15fKPO546/-d546d -)(idjklr&' #Средство блокировки CSRF атаки


@app.route('/')
def main_login():
    return render_template('base_login.html') #Делаем переадресацию страницы на указанный в скобках файл

@app.route('/registration', methods=['GET', 'POST']) #Создали декоратор для формы регистрации и задали ему методы работы
def registration():
    form = Lf()
    if form.validate_on_submit():
        if form.pass_again.data != form.password.data:
            return render_template('registration.html', title='Регистрация', form=form,
                                    message='Пароли не совпадают, повторите ввод пароля')

        with open('authDB.txt', 'a', encoding='utf-8') as file:
            file.write(f'{form.name.data};{form.email.data};{form.password.data}\n') #Записываем данные из формы авторизации в файл с пользователями
        return render_template('registration.html', title='Регистрация', form=form, message='Регистрация прошла успешно')

    return render_template('registration.html', title='Регистрация', form=form)

@app.route('/login', methods=['GET', 'POST']) #Создали декоратор для формы регистрации и задали ему методы работы
def login():
    form = Auth()
    if form.validate_on_submit():
        with open('authDB.txt', 'r', encoding='utf-8') as file:
            data = ''.join(file.readlines())

        if form.email.data not in data:
            return render_template('login.html', title='Авторизация', form=form, message='Введенные данные некорректны, повторите ввод')
        else:
            for i in data.split():
                if form.email.data in i:
                    if i.split(';')[-1] == form.password.data: #Берем последний элемент от начала до конца строки
                        return render_template('login.html', title='Авторизация', form=form, message='Вы успешно авторизовались')
    return render_template('login.html', title='Авторизация', form=form)

if __name__ == '__main__':
    app.run()