# Prodesk

**Система управления IT-проектами и подбора персонала**

## Технологический стек
- C# Основной язык программирования
- .NET 9 Платформа приложения
- Windows Forms Пользовательский интерфейс
- PostgreSQL 18 Реляционная база данных
- Npgsql Взаимодействие с PGSQL
- Docker Контейнеризация БД
- DotNetEnv Загрузка переменных окружения

## Архитектура проекта

Решение построено на основе простой многослойной архитектуры с использованием хороших паттернов ООП.

```text
Prodesk/
├── src/
│   ├── ProDesk.App/
│   │   ├── Формы и пользовательские элементы
│   │   ├── Program.cs
│   │   └── Логика интерфейса
│   │
│   ├── ProDesk.Core/
│   │   ├── Entities/
│   │   └── Interfaces/
│   │
│   └── ProDesk.Infrastructure/
│       ├── Repositories/
│       └── Database/
│
├── database/
│   └── migrations/
│
├── .env.example
└── README.md
```

### Назначение компонентов

**ProDesk.App**

Содержит пользовательский интерфейс Windows Forms, обработчики действий пользователя и точку входа в приложение.

**ProDesk.Core**

Содержит основные сущности предметной области, например `Project`, `Employee` и `Skill`, а также интерфейсы репозиториев.

**ProDesk.Infrastructure**

Отвечает за подключение к PostgreSQL и реализацию репозиториев, выполняющих операции с базой данных.

**Database**

Содержит SQL-миграции для создания и изменения структуры базы данных. 

### Требования

Перед запуском необходимо установить:

- [.NET 9 SDK](https://dotnet.microsoft.com/download/dotnet/9.0)
- [Docker Desktop](https://www.docker.com/products/docker-desktop/)
- Git

## Установка переменных окружения

Пример содержимого:
```env
DB_HOST=localhost
DB_PORT=5433
DB_NAME=prodesk
DB_USER=prodesk
DB_PASSWORD=your_password
```

## Запуск PostgreSQL
Приложение ожидает подключения к базе по адресу `localhost:5433`.
