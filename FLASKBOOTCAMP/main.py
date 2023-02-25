from flask import Flask

app = Flask(__name__)

@app.route('/')
def main_page():
    return "<h1>Hello, world</h1><br><a href='/index'>INDEX</a>"

@app.route('/index/<x>/<y>')
def index_page(x,y):
    return f'<h2>Index page</h2> {int(x) + int(y)}'

if __name__ == '__main__':
    app.run()
