/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package tarjeta;

import java.io.FileNotFoundException;
import java.io.IOException;
import java.io.RandomAccessFile;
import java.util.logging.Level;
import java.util.logging.Logger;

/**
 *
 * @author auren
 */
public class Cliente1File {
    private RandomAccessFile archivo;
    private int RECORD_SIZE = 115;
    
        public Cliente1File(String nombreArchivo){
        try {
            archivo = new RandomAccessFile(nombreArchivo, "rw");
        } 
        catch (FileNotFoundException ex) {
            Logger.getLogger(Cliente1File.class.getName()).log(Level.SEVERE, null, ex);
        }
    }
        
    public int grabar(Cliente1 cliente, int numReg){ 
        try {
            long pos;
            pos = archivo.length();//Length 30 + 30 + 30 + 10 + 15 = 115
            
            if(numReg >=0){
            pos = RECORD_SIZE * numReg;
            }
            
            archivo.seek(pos);
            //Graba nombre del cliente
            String n = cliente.getNombre();
            n = getFixedString(n, 30);
            archivo.writeBytes(n);
            
            //Graba correo del cliente
            n = cliente.getCorreo();
            n = getFixedString(n, 10);
            archivo.writeBytes(n);
            
            //Graba el telefono
            n = cliente.getCorreo();
            n = getFixedString(n, 30);
            archivo.writeBytes(n);
            
            //Graba domicilio del cliente
            n = cliente.getDomicilio();
            n = getFixedString(n, 30);
            archivo.writeBytes(n);
            
            //Graba clave del cliente
            n = cliente.getClave();
            n = getFixedString(n, 15);
            archivo.writeBytes(n);
            
        } catch (IOException ex) {
            Logger.getLogger(Cliente1.class.getName()).log(Level.SEVERE, null, ex);
        }
        return -1;
    }
        
        private String getFixedString(String s, int len){
        StringBuilder sb = new StringBuilder(s);
        
        sb.setLength(len);
        
        return sb.toString();
    }
    
}
