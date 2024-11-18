import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { RouterOutlet } from '@angular/router';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet,FormsModule],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {
  title = 'app';

  message: string = 'Hello, Angular!';

  onchange(value: string) {
    this.message = value;
  }

  updateMessage() {
    this.message = 'Updated message on button click!';
  }
}
