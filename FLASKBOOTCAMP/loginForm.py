from flask_wtf import FlaskForm
from wtforms import StringField, PasswordField, BooleanField, SubmitField, EmailField
from wtforms.validators import DataRequired


class Lf(FlaskForm):
    name = StringField("Имя", validators=[DataRequired()])
    password = PasswordField("Пароль", validators=[DataRequired()])
    pass_again = PasswordField("Повторите пароль", validators=[DataRequired()])
    email = EmailField("E-mail", validators=[DataRequired()])
    rememeber_me = BooleanField("Запомнить меня")
    submit = SubmitField("Зарегистрироваться")


