using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Suwak
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class QuotesPage : ContentPage
	{
		string[] quotes = new string[]
		{
			"The only way to do great work is to love what you do. - Steve Jobs",
			"Life is what happens when you're busy making other plans. - John Lennon",
			"Success is not final, failure is not fatal: It is the courage to continue that counts. - Winston Churchill",
			"The only thing necessary for the triumph of evil is for good men to do nothing. - Edmund Burke",
			"In three words I can sum up everything I've learned about life: it goes on. - Robert Frost",
			"The best way to predict the future is to create it. - Peter Drucker",
			"The journey of a thousand miles begins with a single step. - Lao Tzu",
			"To be yourself in a world that is constantly trying to make you something else is the greatest accomplishment. - Ralph Waldo Emerson",
			"In the end, we will remember not the words of our enemies, but the silence of our friends. - Martin Luther King Jr.",
			"The future belongs to those who believe in the beauty of their dreams. - Eleanor Roosevelt",
			"To be or not to be, that is the question. - William Shakespeare",
			"Two things are infinite: the universe and human stupidity; and I'm not sure about the universe. - Albert Einstein",
			"I have a dream. - Martin Luther King Jr.",
			"Life is 10% what happens to us and 90% how we react to it. - Charles R. Swindoll",
			"The only thing we have to fear is fear itself. - Franklin D. Roosevelt",
			"Be yourself; everyone else is already taken. - Oscar Wilde",
			"The way to get started is to quit talking and begin doing. - Walt Disney",
			"You miss 100% of the shots you don't take. - Wayne Gretzky",
			"Don't count the days, make the days count. - Muhammad Ali",
			"In the middle of every difficulty lies opportunity. - Albert Einstein",
			"It is during our darkest moments that we must focus to see the light. - Aristotle Onassis",
			"What lies behind us and what lies before us are tiny matters compared to what lies within us. - Ralph Waldo Emerson",
			"You can't blame gravity for falling in love. - Albert Einstein",
			"The only true wisdom is in knowing you know nothing. - Socrates",
			"The only limit to our realization of tomorrow will be our doubts of today. - Franklin D. Roosevelt",
			"In the end, we will remember not the words of our enemies, but the silence of our friends. - Martin Luther King Jr.",
			"Believe you can and you're halfway there. - Theodore Roosevelt",
			"Change your thoughts and you change your world. - Norman Vincent Peale",
			"It always seems impossible until it's done. - Nelson Mandela",
			"The greatest glory in living lies not in never falling, but in rising every time we fall. - Nelson Mandela",
			"The best way to predict the future is to create it. - Peter Drucker",
			"Life is really simple, but we insist on making it complicated. - Confucius",
			"Keep your face always toward the sunshine—and shadows will fall behind you. - Walt Whitman",
			"What we think, we become. - Buddha",
			"Everything you've ever wanted is on the other side of fear. - George Addair"
		};


		public QuotesPage()
		{
			InitializeComponent();
		}

		private void slider_ValueChanged(object sender, ValueChangedEventArgs e)
		{
			double sliderValue = Math.Round(e.NewValue);

			slider.Value = sliderValue;

			sliderLabel.Text = "Font size: " + sliderValue;
			sliderLabel.FontSize = sliderValue;

			quote.Text = quotes[(int)sliderValue - 16];
			quote.FontSize = sliderValue;
        }
    }
}