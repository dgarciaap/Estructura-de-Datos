/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package tarjeta;

import java.io.FileNotFoundException;
import java.io.IOException;
import java.io.RandomAccessFile;
import java.util.ArrayList;
import java.util.logging.Level;
import java.util.logging.Logger;

/**
 *
 * @author Diana
 */
public class ProductoFile {
    private RandomAccessFile archivo;
     private final int RECORD_SIZE = 38;
    
    public ProductoFile(String nombreArchivo){
        try {
            archivo = new RandomAccessFile(nombreArchivo, "rw");
        } 
        catch (FileNotFoundException ex) {
            Logger.getLogger(ProductoFile.class.getName()).log(Level.SEVERE, null, ex);
        }
    }
    
    private int getTotalRegistros(){
        try {
            return (int)(archivo.length() / RECORD_SIZE);
        } catch (IOException ex) {
            Logger.getLogger(ProductoFile.class.getName()).log(Level.SEVERE, null, ex);
        }
        return -1;
    }
    
    public ArrayList<Producto> getTodos(){
        try {
            ArrayList<Producto> todos = new ArrayList();
            
            for(int i = 0; i < archivo.length() / RECORD_SIZE; i++){
                Producto p = getProducto(i);
                p.setNumeroRegistro(i);
                todos.add(p);
            }
            return todos;
        } catch (IOException ex) {
            Logger.getLogger(ProductoFile.class.getName()).log(Level.SEVERE, null, ex);
        }
        return null;
    }
    
    public Producto getProducto(int numReg){
        try {
            int pos = RECORD_SIZE * numReg;
            archivo.seek(pos);
            
            byte b[] = new byte [30];
            archivo.read(b);
            String nombre = getFixedString(b);
            
            float costo = archivo.readFloat();
            
            int puntos = archivo.readInt();
            
            return new Producto(nombre, costo, puntos);
        } catch (IOException ex) {
            Logger.getLogger(ProductoFile.class.getName()).log(Level.SEVERE, null, ex);
        }
        return null;
    }
    
        public int grabar(Producto producto, int numReg){ //Graba producto y en qué posición
        try {
            
            long pos = archivo.length();//Length 30 + 4 + 4 = 38
            
            if(numReg >= 0){//Calcular posición
                pos = RECORD_SIZE * numReg;
            }
            archivo.seek(pos);
            
            //Graba nombre del producto
            String n = producto.getNombre();
            n = getFixedString(n, 30);
            archivo.writeBytes(n);
            
            //Graba el costo
            archivo.writeFloat(producto.getCosto());
            
            //Graba los puntos
            archivo.writeInt(producto.getPuntos());
            
            
            if(numReg == -1)
            {
                return (getTotalRegistros() -1);//Registro nuevo, darle un nuevo numReg
            }
            else {
                return numReg;//Si no es nuevo sólo regresa el numReg que tiene
            }
            
        } catch (IOException ex) {
            Logger.getLogger(ProductoFile.class.getName()).log(Level.SEVERE, null, ex);
        }
        return -1;//Validar, si regresa -1 existe un error
    }
    
    private String getFixedString(String s, int len){
        StringBuilder sb = new StringBuilder(s);
        
        sb.setLength(len);
        
        return sb.toString();
    }
    
        private String getFixedString(byte b[]){
        String s = new String(b);
        
        int fin = s.indexOf('\0');
        
        return s.substring(0, fin);
    }
}
