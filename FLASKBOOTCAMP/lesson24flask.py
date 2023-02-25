from flask import Flask, render_template
from random import randint as rd

app = Flask(__name__)

file = open('file.txt', 'r', encoding='utf-8')

resultData = list()

for line in file.readlines():
    resultData.append(tuple(line.split('\n')[0].split(';')))

file.close()

@app.route('/')
def main_page():
    name = resultData
    game = rd(0, 1)
    return render_template('base.html', name=name, game=game) #Делаем переадресацию главной страницы на указанный в скобках файл

@app.route('/index/<x>/<y>')
def index_page(x,y):
    return f'<h2>Index page</h2> {int(x) + int(y)}'

if __name__ == '__main__':
    app.run()