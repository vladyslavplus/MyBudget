﻿namespace MyBudget.BLL.Exceptions;

public class NotFoundException(string message) : Exception(message);