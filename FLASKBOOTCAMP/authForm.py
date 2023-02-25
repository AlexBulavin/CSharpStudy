from flask_wtf import FlaskForm
from wtforms import StringField, PasswordField, BooleanField, SubmitField, EmailField
from wtforms.validators import DataRequired


class Auth(FlaskForm):
    password = PasswordField("Пароль", validators=[DataRequired()])
    email = EmailField("E-mail", validators=[DataRequired()])
    rememeber_me = BooleanField("Запомнить меня")
    submit = SubmitField("Войти в аккаунт")

