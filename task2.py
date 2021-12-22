from os import name
from flask import Flask, render_template,url_for
from werkzeug.exceptions import abort

class Person:
    def __init__(self, name,age, university):
        self.name = name
        self.age = age
        self.university = university

persons = []
persons.append(Person('Daniil', 20, 'MAI'))
persons.append(Person('Ramzan', 45, 'President of Chechnya'))
persons.append(Person('Vestyak',85, 'MAI'))
persons.append(Person('test', 100, 'test'))

app = Flask(__name__)

@app.route("/index")
def index():
    return render_template('index.html')

@app.route("/users")
def users():
    return render_template('users.html',persons=persons)

@app.route("/users/<user>")
def profile(user):
    for p in persons:
        if user == p.name:
            return f"user : {user}"
    abort(404)
    
        

if __name__ == "__main__":
    app.run(debug=True)