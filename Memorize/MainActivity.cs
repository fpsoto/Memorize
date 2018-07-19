using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Android.App;
using Android.Widget;
using Android.OS;
using Android.Views;

namespace Memorize
{
    [Activity(Label = "Memorize", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        private int Last { get; set; }
        private static List<int> listPiscs { get; set; }
        private static List<ImageButton> listButtons { get; set; }
        private static EditText txtWon { get; set; }

        protected override void OnCreate(Bundle bundle)
        {
            Last = 0;

            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            // SetContentView (Resource.Layout.Main);

            SetContentView(Resource.Layout.Main);

            listButtons = new List<ImageButton>();

            txtWon = FindViewById<EditText>(Resource.Id.txtWon);

            //firstCol
            var image1 = FindViewById<ImageButton>(Resource.Id.imageButton1);
            var image2 = FindViewById<ImageButton>(Resource.Id.imageButton2);
            var image3 = FindViewById<ImageButton>(Resource.Id.imageButton3);

            image1.SetImageResource(Resource.Drawable.sample_back);
            image2.SetImageResource(Resource.Drawable.sample_back);
            image3.SetImageResource(Resource.Drawable.sample_back);

            var image4 = FindViewById<ImageButton>(Resource.Id.imageButton4);
            var image5 = FindViewById<ImageButton>(Resource.Id.imageButton5);
            var image6 = FindViewById<ImageButton>(Resource.Id.imageButton6);

            image4.SetImageResource(Resource.Drawable.sample_back);
            image5.SetImageResource(Resource.Drawable.sample_back);
            image6.SetImageResource(Resource.Drawable.sample_back);

            var image7 = FindViewById<ImageButton>(Resource.Id.imageButton7);
            var image8 = FindViewById<ImageButton>(Resource.Id.imageButton8);
            var image9 = FindViewById<ImageButton>(Resource.Id.imageButton9);

            image7.SetImageResource(Resource.Drawable.sample_back);
            image8.SetImageResource(Resource.Drawable.sample_back);
            image9.SetImageResource(Resource.Drawable.sample_back);

            var image10 = FindViewById<ImageButton>(Resource.Id.imageButton10);
            var image11 = FindViewById<ImageButton>(Resource.Id.imageButton11);
            var image12 = FindViewById<ImageButton>(Resource.Id.imageButton12);

            image10.SetImageResource(Resource.Drawable.sample_back);
            image11.SetImageResource(Resource.Drawable.sample_back);
            image12.SetImageResource(Resource.Drawable.sample_back);
            
            var btnReset = FindViewById<Button>(Resource.Id.btnReset);
            btnReset.Click += (sender, e) =>
            {
                foreach (var item in listButtons)
                {
                    item.Enabled = true;
                    item.Visibility = ViewStates.Visible;
                }

                txtWon.Text = "0";
            };

            listPiscs = new List<int>();

            listPiscs.Add(Resource.Drawable.sample_4);
            listPiscs.Add(Resource.Drawable.sample_3);
            listPiscs.Add(Resource.Drawable.sample_6);
            listPiscs.Add(Resource.Drawable.sample_6);
            listPiscs.Add(Resource.Drawable.sample_2);
            listPiscs.Add(Resource.Drawable.sample_5);
            listPiscs.Add(Resource.Drawable.sample_7);
            listPiscs.Add(Resource.Drawable.sample_4);
            listPiscs.Add(Resource.Drawable.sample_3);
            listPiscs.Add(Resource.Drawable.sample_2); ;
            listPiscs.Add(Resource.Drawable.sample_7);
            listPiscs.Add(Resource.Drawable.sample_5);

            listButtons.Add(image1);
            listButtons.Add(image2);
            listButtons.Add(image3);
            listButtons.Add(image4);
            listButtons.Add(image5);
            listButtons.Add(image6);
            listButtons.Add(image7);
            listButtons.Add(image8);
            listButtons.Add(image9);
            listButtons.Add(image10);
            listButtons.Add(image11);
            listButtons.Add(image12);

            image1.Click += (sender, e) =>
             {
                 image1.SetImageResource(listPiscs[0]);

                 Toast.MakeText(this, "1", ToastLength.Short).Show();

                 if (Last == 0)
                     Last = 1;
                 else
                 {
                     AreSameCard(1, Last);
                     Last = 0;

                 }
             };

            image2.Click += (sender, e) =>
             {
                 image2.SetImageResource(listPiscs[1]);


                 Toast.MakeText(this, image2.Id.ToString(), ToastLength.Short).Show();

                 if (Last == 0)
                     Last = 2;
                 else
                 {
                     AreSameCard(2, Last);
                     Last = 0;

                 }

             };

            image3.Click += (sender, e) =>
             {
                 image3.SetImageResource(listPiscs[2]);


                 Toast.MakeText(this, image3.Id.ToString(), ToastLength.Short).Show();

                 if (Last == 0)
                     Last = 3;
                 else
                 {
                     AreSameCard(3, Last);
                     Last = 0;

                 }

             };

            //secondCol
            image4.Click += (sender, e) =>
             {
                 image4.SetImageResource(listPiscs[3]);

                 Toast.MakeText(this, image4.Id.ToString(), ToastLength.Short).Show();

                 if (Last == 0)
                     Last = 4;
                 else
                 {
                     AreSameCard(4, Last);
                     Last = 0;

                 }

             };

            image5.Click += (sender, e) =>
             {
                 image5.SetImageResource(listPiscs[4]);

                 Toast.MakeText(this, image5.Id.ToString(), ToastLength.Short).Show();

                 if (Last == 0)
                     Last = 5;
                 else
                 {
                     AreSameCard(5, Last);
                     Last = 0;

                 }

             };

            image6.Click += (sender, e) =>
             {
                 image6.SetImageResource(listPiscs[5]);

                 Toast.MakeText(this, image6.Id.ToString(), ToastLength.Short).Show();

                 if (Last == 0)
                     Last = 6;
                 else
                 {
                     AreSameCard(6, Last);
                     Last = 0;
                 }
             };

            image7.Click += (sender, e) =>
            {
                image7.SetImageResource(listPiscs[6]);

                Toast.MakeText(this, image7.Id.ToString(), ToastLength.Short).Show();

                if (Last == 0)
                    Last = 7;
                else
                {
                    AreSameCard(7, Last);
                    Last = 0;
                }
            };

            image8.Click += (sender, e) =>
            {
                image8.SetImageResource(listPiscs[7]);

                Toast.MakeText(this, image8.Id.ToString(), ToastLength.Short).Show();

                if (Last == 0)
                    Last = 8;
                else
                {
                    AreSameCard(8, Last);
                    Last = 0;
                }
            };

            image9.Click += (sender, e) =>
            {
                image9.SetImageResource(listPiscs[8]);

                Toast.MakeText(this, image9.Id.ToString(), ToastLength.Short).Show();

                if (Last == 0)
                    Last = 9;
                else
                {
                    AreSameCard(9, Last);
                    Last = 0;
                }
            };

            image10.Click += (sender, e) =>
            {
                image10.SetImageResource(listPiscs[9]);

                Toast.MakeText(this, image10.Id.ToString(), ToastLength.Short).Show();

                if (Last == 0)
                    Last = 10;
                else
                {
                    AreSameCard(10, Last);
                    Last = 0;
                }
            };

            image11.Click += (sender, e) =>
            {
                image11.SetImageResource(listPiscs[10]);

                Toast.MakeText(this, image11.Id.ToString(), ToastLength.Short).Show();

                if (Last == 0)
                    Last = 11;
                else
                {
                    AreSameCard(11, Last);
                    Last = 0;
                }
            };

            image12.Click += (sender, e) =>
            {
                image12.SetImageResource(listPiscs[11]);

                Toast.MakeText(this, image12.Id.ToString(), ToastLength.Short).Show();

                if (Last == 0)
                    Last = 12;
                else
                {
                    AreSameCard(12, Last);
                    Last = 0;
                }
            };

        }

        public static async Task AreSameCard(int current, int last)
        {
            await Task.Delay(1000);
            if (listPiscs[current - 1] == listPiscs[last - 1])
            {
                int amount = Convert.ToInt32(txtWon.Text);
                amount++;
                txtWon.Text = amount.ToString();

                listButtons[current - 1].Enabled = false;
                listButtons[last - 1].Enabled = false;

                listButtons[current - 1].Visibility = ViewStates.Invisible;
                listButtons[last - 1].Visibility = ViewStates.Invisible;
            }

            listButtons[current - 1].SetImageResource(Resource.Drawable.sample_back);
            listButtons[last - 1].SetImageResource(Resource.Drawable.sample_back);
        }

        public static List<int> ListPics()
        {
            List<int> newList = new List<int>();

            newList.Add(Resource.Drawable.sample_2);
            newList.Add(Resource.Drawable.sample_2);
            newList.Add(Resource.Drawable.sample_3);
            newList.Add(Resource.Drawable.sample_3);
            newList.Add(Resource.Drawable.sample_4);
            newList.Add(Resource.Drawable.sample_4);

            return Shuffle(newList);
        }

        public static List<T> Shuffle<T>(List<T> list)
        {
            Random rng = new Random();
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }

            return list;
        }

    }
}

