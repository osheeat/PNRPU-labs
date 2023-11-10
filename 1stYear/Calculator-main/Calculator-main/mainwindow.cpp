#include "mainwindow.h"
#include "ui_mainwindow.h"
#include<QPixmap>
#include<QMessageBox>
#include<QString>

MainWindow::MainWindow(QWidget *parent)
    : QMainWindow(parent)
    , ui(new Ui::MainWindow)
{
    ui->setupUi(this);

    connect(ui->pushButton, SIGNAL(clicked()), this, SLOT(DataCalculation()));
    connect(ui->pushButton_2, SIGNAL(clicked()), this, SLOT(Discharge()));
    connect(ui->pushButton_3, SIGNAL(clicked()), this, SLOT(CancelLast()));

    QPixmap bkgnd ("D:/PROJECTS/qt_projects/Tvorc/img/yungmoni.jpg");
    bkgnd = bkgnd.scaled(this->size(), Qt::IgnoreAspectRatio);
    QPalette palette;
    palette.setBrush(QPalette::Background, bkgnd);
    this->setPalette(palette);
}

MainWindow::~MainWindow()
{
    delete ui;
}


QString Memtmp;
QString Memtmp2;
QString Memtmp3;

void MainWindow::DataCalculation()
{
    double sum_of_cred = 0.0;
    double count_of_ages = 0.0;
    double percents = 0.0;
    double begin_sum;

    QString str1 = ui->lineEdit->text();
    QString str2 = ui->lineEdit_2->text();
    QString str3 = ui->lineEdit_3->text();

    QString tmp = "-";
    QString tmp2 = "-";
    QString tmp3 = "-";



    for (int i = 0;i < str1.length();i++)
    {
        if (str1[i] >= '0' && str1[i]<= '9')
            sum_of_cred = str1.toFloat();
    }
    for (int i = 0;i < str2.length();i++)
    {
        if (str2[i] >= '0' && str2[i]<= '9' )
            count_of_ages = str2.toFloat();
    }
    for (int i = 0;i < str3.length();i++)
    {
        if (str3[i] >= '0' && str3[i]<= '9' )
            percents = str3.toFloat();
    }



    if (sum_of_cred!=0)
    {
        if (count_of_ages!=0)
        {
            if (percents!=0)
            {
                begin_sum = sum_of_cred;
                for (int i=0;i<count_of_ages;i++)
                {
                    sum_of_cred = sum_of_cred + (sum_of_cred*percents/100);

                }
                tmp = QString::number(sum_of_cred);
                Memtmp = tmp;
                tmp2 = QString::number(sum_of_cred/count_of_ages);
                Memtmp2 = tmp2;

                tmp3 = QString::number(sum_of_cred - begin_sum);
                Memtmp3 = tmp3;
            }
            else
                QMessageBox::critical(this, "Ошибка!", "Введен неправильный тип данных (Процентная ставка)");
        }
        else
            QMessageBox::critical(this, "Ошибка!", "Введен неправильный тип данных (Количество лет)");
    }
    else
        QMessageBox::critical(this, "Ошибка!", "Введен неправильный тип данных (Сумма кредита)");



    ui->lineEdit_5->setText(tmp); // задаем имя кнопки равным финальной строке
    ui->lineEdit_4->setText(tmp2);
    ui->lineEdit_6->setText(tmp3);


}

void MainWindow::Discharge()
{
    ui->lineEdit_5->setText("-"); // задаем имя кнопки равным финальной строке
    ui->lineEdit_4->setText("-");
    ui->lineEdit_6->setText("-");
}

void MainWindow::CancelLast()
{

    if (ui->lineEdit_5->text() == "-")
    {
         ui->lineEdit_5->setText(Memtmp);
         ui->lineEdit_4->setText(Memtmp2);
         ui->lineEdit_6->setText(Memtmp3);
    }
    else
    {
        ui->lineEdit_5->setText("-"); // задаем имя кнопки равным финальной строке
        ui->lineEdit_4->setText("-");
        ui->lineEdit_6->setText("-");
    }
}
