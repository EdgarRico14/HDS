package com.example;

import javafx.application.Application;
import javafx.geometry.Insets;
import javafx.scene.Scene;
import javafx.scene.control.Button;
import javafx.scene.control.CheckBox;
import javafx.scene.control.Label;
import javafx.scene.control.RadioButton;
import javafx.scene.control.TextField;
import javafx.scene.control.ToggleGroup;
import javafx.scene.layout.HBox;
import javafx.scene.layout.VBox;
import javafx.stage.Stage;

public class UI extends Application {
    @Override
    public void start(Stage primaryStage) {
        primaryStage.setTitle("Ejemplo de UI en JavaFX en VSC");

        Label label = new Label("Mi primer UI!");
        label.setStyle("-fx-font-size: 20px; -fx-font-weight: bold;");

        TextField textField = new TextField();
        textField.setPromptText("Escribe algo aquí...");
        textField.setStyle("-fx-padding: 10px; -fx-border-radius: 5px; -fx-background-radius: 20px;");

        Button button = new Button("Haz clic aquí");
        button.setStyle("-fx-background-color: #007bff; -fx-text-fill: white; -fx-padding: 10px 20px; -fx-border-radius: 5px; -fx-background-radius: 5px;");
        button.setOnAction(e -> label.setText("¡Botón clicado!"));

        CheckBox checkBox = new CheckBox("Acepto los términos y condiciones");
        checkBox.setStyle("-fx-padding: 10px;");

        RadioButton radioButton1 = new RadioButton("Opción 1");
        RadioButton radioButton2 = new RadioButton("Opción 2");
        ToggleGroup radioGroup = new ToggleGroup();
        radioButton1.setToggleGroup(radioGroup);
        radioButton2.setToggleGroup(radioGroup);

        HBox radioButtons = new HBox(10, radioButton1, radioButton2);
        radioButtons.setPadding(new Insets(10, 0, 10, 0));

        VBox layout = new VBox(15);
        layout.setPadding(new Insets(20));
        layout.getChildren().addAll(label, textField, button, checkBox, radioButtons);

        Scene scene = new Scene(layout, 400, 400);
        primaryStage.setScene(scene);
        primaryStage.show();
    }

    public static void main(String[] args) {
        launch(args);
    }
}
