from flask import Flask, render_template
from random import randint as rd
from loginForm import Lf

app = Flask(__name__)
app.config['SECRET_KEY'] = '15fKPO546/-d546d -)(idjklr&' #Средство блокировки CSRF атаки


@app.route('/')
def main_login():
    return render_template('base_login.html') #Делаем переадресацию страницы на указанный в скобках файл

@app.route('/registration', methods=['GET', 'POST']) #Создали декоратор для формы регистрации и задали ему методы работы
def registration():
    form = Lf()
    if form.validate_on_submit():
        pass

    return render_template('registration.html', title='Регистрация', form=form)


if __name__ == '__main__':
    app.run()