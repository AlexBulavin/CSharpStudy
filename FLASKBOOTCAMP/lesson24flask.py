from flask import Flask, render_template
from random import randint as rd

app = Flask(__name__)


@app.route('/')
def main_page():
    with open('file.txt', 'r', encoding='utf-8') as file:
        resultData = list()
        for line in file.readlines():
            resultData.append(tuple(line.split('\n')[0].split(';')))
    game = rd(0, 1)
    return render_template('base.html', data=resultData, game=game) #Делаем переадресацию главной страницы на указанный в скобках файл

@app.route('/index/<x>/<y>')
def index_page(x,y):
    return f'<h2>Index page</h2> {int(x) + int(y)}'

@app.route('/about')
def about():
    return render_template('about.html')



if __name__ == '__main__':
    app.run()