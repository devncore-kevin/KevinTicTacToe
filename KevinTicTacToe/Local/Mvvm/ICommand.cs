﻿using System;
using System.Windows.Input;

namespace LucasTicTacToe.Local.Mvvm
{
    public class RelayCommand<T> : ICommand
	{
		#region Fields

		readonly Action<T> _execute = null;
		readonly Predicate<T> _canExecute = null;

		#endregion

		#region Constructors

		public RelayCommand(Action<T> execute)
			: this(execute, null)
		{
		}

		public RelayCommand(Action<T> execute, Predicate<T> canExecute)
		{
			if (execute == null)
				throw new ArgumentNullException("execute");

			_execute = execute;
			_canExecute = canExecute;
		}

		#endregion

		#region ICommand Members

		public bool CanExecute(object parameter)
		{
			return _canExecute == null ? true : _canExecute((T)parameter);
		}

		public event EventHandler CanExecuteChanged
		{
			add { CommandManager.RequerySuggested += value; }
			remove { CommandManager.RequerySuggested -= value; }
		}

		public void Execute(object parameter)
		{
			_execute((T)parameter);
		}

		#endregion
	}
}
